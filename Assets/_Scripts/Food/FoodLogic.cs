using Farm._Scripts.Items;
using Farm.States;
using UnityEngine;

namespace Farm._Scripts
{
    public sealed class FoodLogic : MonoBehaviour
    {
        [SerializeField] private FoodData _foodData;
        [SerializeField] private GameObject _foodModel;
        [SerializeField] private GrowTimerUI _growTimerUI;

        public IState RipeState;
        public IState GrowState;

        private StateMachine _stateMachine;

        private void Awake()
        {
            RipeState = new RipeState(_foodModel);
            GrowState = new GrowState(this, _foodData, _foodModel, _growTimerUI);
            _stateMachine = new StateMachine(GrowState);
        }

        private void Update()
        {
            _stateMachine.CurrentState.Update();
        }

        public void ChangeState(IState state)
        {
            _stateMachine.ChangeState(state);
        }
    }
}