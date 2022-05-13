using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    // Vari�vel para o NavMeshAgent.
    public NavMeshAgent agent;

    private void Start()
    {   
        // Pega o componente NavMeshAgent no gameobject que est� o script.
        agent = this.GetComponent<NavMeshAgent>();
    }
}