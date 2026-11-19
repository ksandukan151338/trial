using System;

namespace tagUMpay
{
    public abstract class User
    {
        private int userId;
        private string username;
        private string passwordHash;
        private string enteredPassword;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string PasswordHash
        {
            get { return passwordHash; }
            set { passwordHash = value; }
        }

        public void SetEnteredPassword(string password)
        {
            enteredPassword = password;
        }

        public bool authenticate()
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(enteredPassword))
            {
                return false;
            }

            return passwordHash == enteredPassword;
        }

        public abstract void getDashboardOptions();
    }
}