using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovementState : PlayerState
{
    protected Vector2 input;
    protected float inputX;

    protected Movement Movement { get => movement ?? core.GetCoreComponent(ref movement); }
    private Movement movement;

    public BaseMovementState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        input = player.InputHandler.RawMovementInput;
        inputX = player.InputHandler.inputX;
    }

}
