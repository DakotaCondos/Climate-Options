using UnityEngine;
using Firebase.Auth;
using Firebase.Database;

public class FirebaseInteract : MonoBehaviour
{
    public DatabaseReference databaseReference;
    public FirebaseAuth firebaseAuth;
    void Start()
    {
        // Get the root reference location of the database.
        DatabaseReference databaseReference = FirebaseDatabase.DefaultInstance.RootReference;
    }
}
