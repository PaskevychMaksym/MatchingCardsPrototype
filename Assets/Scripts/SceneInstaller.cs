using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject _cardPrefab;

    [SerializeField]
    private GameManager _gameManager;
    [SerializeField]
    private GridManager _gridManager;
    [SerializeField]
    private HintSystem _hintSystem;
    
    public override void InstallBindings()
    {
        Container.Bind<GameManager>().FromInstance(_gameManager).AsSingle();
        Container.Bind<GridManager>().FromInstance(_gridManager).AsSingle();
        Container.Bind<HintSystem>().FromInstance(_hintSystem).AsSingle();

        Container.BindFactory<CardController, CardController.Factory>().FromComponentInNewPrefab(_cardPrefab);
    }
}