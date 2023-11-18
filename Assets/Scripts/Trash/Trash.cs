using UnityEngine;

public class Trash : MonoBehaviour {

    private Animator anim;

    [SerializeField]
    private GameObject food;

    [SerializeField]
    private SearchBar searchBar;

    private void Start() {
        anim = GetComponent<Animator>();
        searchBar.endSearchingFoodEvent.AddListener(endSearchFood);   //Quando a barra de busca chegar ao fim, ser� ativado o m�todo endSearchFood
    }

    public void startSearchingFood() {     //Este m�todo ser� chamado quando o jogador interagir com a lixeira
        if (gameObject.tag == "TrashClosed")
            searchBar.gameObject.SetActive(true);
    }

    public void stopSearchingFood() {     //Este m�todo ser� chamado quando o jogador solatar a tecla Z ao interagir com a lixeira
        if (gameObject.tag == "TrashClosed")
            searchBar.gameObject.SetActive(false);
    }

    public void endSearchFood() {
        searchBar.gameObject.SetActive(false);
        anim.SetBool("open", true);
        gameObject.tag = "TrashOpened";
        food.SetActive(true);
    }
}
