﻿using UnityEngine;
using UnityEngine.AI;

public class Mover : IMover
{
    private readonly Player _player;
    private readonly CharacterController _characterController;
    private NavMeshAgent _navMeshAgent;

    public Mover( Player player )
    {
        _player = player;
        _characterController = _player.GetComponent<CharacterController>();
        _player.GetComponent<NavMeshAgent>().enabled = false;
    }

    public void Tick()
    {
        Vector3 movementInput = new Vector3(_player.PlayerInput.Horizontal, 0, _player.PlayerInput.Vertical);
        Vector3 movement = _player.transform.rotation * movementInput;
        _characterController.SimpleMove(movement);
    }
}