using UnityEngine;

namespace Chapter.State {
public class ClientState : MonoBehaviour {

        private BikeController _bikeController;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start() {
            _bikeController = (BikeController)FindAnyObjectByType(typeof(BikeController));
        }

        void OnGUI() {
            GUILayout.Space(20);
            if (GUILayout.Button("Start Bike")) {
                _bikeController.StartBike();
            }
            if (GUILayout.Button("Turn Left")) {
                _bikeController.Turn(Direction.Left);
            }
            if (GUILayout.Button("Turn Right")) {
                _bikeController.Turn(Direction.Right);
            }
            if (GUILayout.Button("Stop Bike")) {
                _bikeController.StopBike();
            }
        }
    }
}