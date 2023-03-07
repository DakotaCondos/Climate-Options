using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Extensions;

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
