using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    // Array de gameobjects.
    GameObject[] agents;

    private void Start()
    {
        // Atribui a variável "agents" (array de gameobjects), todos os gameobjects com a tag "ai" (objetos vermelho e azul).
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    private void Update()
    {
        // Se apertar o motão esquerdo do mouse:
        if (Input.GetMouseButtonDown(0))
        {
            // Pega a posição do mapa em que o usuário clicou.
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                // Para cada gameobjects do array "agents":
                foreach (GameObject a in agents)
                {
                    // Faz mover o gameobject pegando o script "AIControl" e passando o destino (onde floi clicado com o mouse).
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
                }
            }
        }
    }
}