using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Auth;
using TMPro;
using System;
using System.Text.RegularExpressions;
using System.Globalization;
using Firebase;

public class AuthController : MonoBehaviour
{
    [SerializeField]
    public TMP_Text email;
    [SerializeField]
    public TMP_Text password1;
    [SerializeField]
    public TMP_Text password2;
    [SerializeField]
    public TMP_Text responseRed;
    [SerializeField]
    public TMP_Text responseGreen;

    public void Login()
    {
        if (!VerifyFields()) return;

        FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordAsync(email.text, password1.text).ContinueWith(task =>
        {
            if (task.IsCanceled)
            {
            }
            if (task.IsFaulted)
            {
                Firebase.FirebaseException e =
                task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;

                GetErrorMessage((AuthError)e.ErrorCode);

                return;
            }
            if (task.IsCompleted)
            {
            }
        });
    }

    private void GetErrorMessage(AuthError errorCode)
    {
        string message = "";
        message = errorCode.ToString();


        Debug.Log(message);
    }

    public void LoginAnonymous()
    {

    }

    public void ResgisterUser()
    {
        if (!VerifyFields()) return;

        FirebaseAuth.DefaultInstance.CreateUserWithEmailAndPasswordAsync(email.text, password1.text).ContinueWith(task =>
        {
            if (task.IsCanceled)
            {
                Firebase.FirebaseException e =
                task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;

                GetErrorMessage((AuthError)e.ErrorCode);

                return;
            }
            if (task.IsFaulted)
            {
                Firebase.FirebaseException e =
                task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;

                GetErrorMessage((AuthError)e.ErrorCode);

                return;
            }
            if (task.IsCompleted)
            {
                Debug.Log("ResgisterUser success");
            }
        });

    }

    public void Logout()
    {

    }

    public bool VerifyFields()
    {
        if (!IsValidEmail(email.text))
        {
            Debug.Log("Invalid Email");
            return false;
        }
        if (!IsValidPassword())
        {
            return false;
        }
        return true;
    }

    private bool IsValidPassword()
    {
        //if not null, passwords are matching and length < 7
        if (password1.text == null || password2.text == null)
        {
            Debug.Log("Password Field is null");
            return false;
        }
        if (!String.Equals(password1.text, password2.text))
        {
            Debug.Log("Passwords do not match");
            return false;
        }
        if (password1.text.Length < 7)
        {
            Debug.Log("Password must be 8 characters or more");
            return false;
        }
        return true;
    }



    //IsValidEmail courtesy of Microsoft https://learn.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
    public static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return false;
        }

        try
        {
            // Normalize the domain
            email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                  RegexOptions.None, TimeSpan.FromMilliseconds(200));

            // Examines the domain part of the email and normalizes it.
            string DomainMapper(Match match)
            {
                // Use IdnMapping class to convert Unicode domain names.
                var idn = new IdnMapping();

                // Pull out and process domain name (throws ArgumentException on invalid)
                string domainName = idn.GetAscii(match.Groups[2].Value);

                return match.Groups[1].Value + domainName;
            }
        }
        catch (RegexMatchTimeoutException e)
        {
            return false;
        }
        catch (ArgumentException e)
        {
            return false;
        }

        try
        {
            return Regex.IsMatch(email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }
}

