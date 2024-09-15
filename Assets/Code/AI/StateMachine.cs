using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AttackTypes;
using Dbug;

public class StateMachine : MonoBehaviour
{
    #region ALL POSSIBLE STATES
    /* Do not need to fill all, Start will fill all that an object contains
     */
    protected Idle_State idle; //unlocked
    protected Move_State move; //unlocked
    //attack (soft-)locked (cancellable?)
    protected IAttackType m_swordLightAttack, m_swordHeavyAttack;
    protected Attack_State attack;

    protected Evade_State evade;
    protected Dash_State roll;
    protected Block_State block;
    protected Hit_State hit;

    public bool isHit = false; // /hit details

    public Animator animator;
    //parrying: effect hit sender controlled/staggered, insta execute (and change state?)
    //block: effect hit sender block lag? (and change state. block lag during "blocking" state?)
    //evade: (change state to attack or evade_counter. with invincitiblity or enemy controlled)
    //superarmor/invincible: ignore hit (damage) //still want to registe hits in i-frames

    //otherwise, take some hit details sent and change state to hit/ stagger

    //dash (/roll, long iframes) locked
    //evade (sidestep, short iframes) locked
    //block \/
    //parry /\
    #endregion

    /// <summary>
    /// runtime variable
    /// </summary>
    protected State currentState;

    private void Start()
    {            // idle.machine = this
        if (idle = GetComponent<Idle_State>())
            Log.Good("Idle found. " + gameObject.name);
        else
            Log.Warning("Idle NOT Found. " + gameObject.name);

        if (move = GetComponent<Move_State>())
            Log.Good("Move Found. " + gameObject.name);
        else
            Log.Warning("Move NOT Found. " + gameObject.name);

        if (attack = GetComponent<Attack_State>())
        {
            Log.Good("Attack Found. " + gameObject.name);
            attack.OnExit += OnLockedStateExit;
        }
        else
        {
            Log.Warning("Attack NOT Found. " + gameObject.name);
        }

        if (evade = GetComponent<Evade_State>())
        {
            Log.Good("Evade Found. " + gameObject.name);
            evade.OnExit += OnLockedStateExit;
        }
        else
            Log.Warning("Evade NOT Found. " + gameObject.name);

        if (roll = GetComponent<Dash_State>())
        {
            Log.Good("Roll Found. " + gameObject.name);
            roll.OnExit += OnLockedStateExit;
        }
        else
            Log.Warning("Roll NOT Found. " + gameObject.name);

        if (block = GetComponent<Block_State>())
        {
            Log.Good("Block Found. " + gameObject.name);
            block.OnExit += OnLockedStateExit;
        }
        else
            Log.Warning("Block NOT Found. " + gameObject.name);

        if (hit = GetComponent<Hit_State>())
        {
            Log.Good("Hit Found. " + gameObject.name);
            hit.OnExit += OnLockedStateExit;
        }
        else
            Log.Warning("Hit NOT Found. " + gameObject.name);

        if (idle != null)
            Initialize(idle);
        else
            Log.Warning("FAILED TO INITIALIZE: Idle NOT Found. " + gameObject.name);
    }



    public virtual void Initialize(State initialState)
    {
        currentState = initialState;
        currentState.Enter();
        m_swordLightAttack = new SwordLightAttack();
        m_swordHeavyAttack = new SwordHeavyAttack();
    }



    public virtual void ApplyHitEffect(StateMachine target, HitDetails hit_details)
    {
        if (target.currentState.ghost)
        {
            //dont register hit? or just deacticvate box instead of a bool
            return;
        }
        else if (target.currentState.invincible)
        {
            target.isHit = true;

            StartCoroutine(FramePauseAfterHitCoroutine(hit_details.frameStun, 0f));
            //take hit
            return;
        }
        else if (target.currentState.superarmor)
        {
            target.isHit = true;

            StartCoroutine(FramePauseAfterHitCoroutine(hit_details.frameStun, 0f));
            //take hit and damage
            return;
        }

        target.hit.stateDuration = hit_details.hitStun;

        //set hitstun of target hit state
        ForceChangeState(target.hit);

        //StartCoroutine(HandleHitEffect(otherEntity, hitPauseDuration));
    }

    //gotta check if this is working correctly
    private IEnumerator FramePauseAfterHitCoroutine(float duration, float pauseTimeScale)
    {
        // Ensure all hit effects are processed before pausing
        yield return new WaitForEndOfFrame();

        // Store the original time scale
        float originalTimeScale = Time.timeScale;

        // Set the time scale to the specified pause time scale (default is 0 for a complete stop)
        Time.timeScale = pauseTimeScale;

        // Wait for the specified duration in real time
        yield return new WaitForSecondsRealtime(duration);

        // Restore the original time scale
        Time.timeScale = originalTimeScale;
    }

    public virtual void ApplyHitEffect( StateMachine target,  StateMachine sender, HitDetails hit_details)
    {
        //check somewhree for repeat attack box interaction 
        //check sender state details: (superarmor : take hit, take damage, no hitstun, 
        //    invincible: take hit, no damage, no hitstun,
        //    ghost: take no hit) < will apply hit
        //effect not at all, or differently depending on the states processing details

        target.isHit = true;

        if (target.currentState.ghost)
        {
            //dont register hit? or just deacticvate box instead of a bool
            return;
        }
        else if (target.currentState.invincible)
        {
            //take hit
            return;
        }
        else if (target.currentState.superarmor)
        {
            //take hit and damage
            return;
        }

        ForceChangeState(target.hit);

        //this.GetComponent<Rigidbody>().velocity = hit_details.direction

        //resolve(
        //appyl damage / velocity
        //changestates / phases(controlled, hit)
        //framestun: (
        //o will "pause" both objects in whatever states/ phases theyve changed to
        //o sometimes
        //
        //hitstun level

        //still recognises as "hit" by some box, now inactive to it
        //skip framepause if necessary


        //ChangeState(hit);
    }

    //parrying: effect hit sender controlled/staggered, insta execute (and change state?)
    //block: effect hit sender block lag? (and change state. block lag during "blocking" state?)
    //evade: (change state to attack or evade_counter. with invincitiblity or enemy controlled)
    //superarmor/invincible: ignore hit (damage) //still want to registe hits in i-frames

    //otherwise, take some hit details sent and change state to hit/ stagger

    protected virtual void ChangeState(State newState)
    {
        //if phase is not locked, or maybe phase switches islocekd

        //currentState.Exit();
        //currentState = newState;
        //currentState.Enter();

        //return;

        //need to change this so can theoertically re-enter same state, like for being hit
        if (!currentState.GetIsLocked()) // if (unlocked state) { switch freely } //currently hit wont go through locked states, but will still happen afterward as ishit is stored.
        {
            //more like, if currentstate not repeateable/restartable, then dont do
            if (newState != currentState) // Change state may be called more times than neccersary 
            {
                currentState.Exit();
                currentState = newState;
                currentState.Enter();
            }
        }
    }

    protected void ForceChangeState(State newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }

    private void OnLockedStateExit()
    {
        currentState = idle;
        currentState.Enter();
    }

    protected virtual void Update()
    {

    }

    protected virtual void FixedUpdate()
    {
        currentState.Execute();
    }
}
