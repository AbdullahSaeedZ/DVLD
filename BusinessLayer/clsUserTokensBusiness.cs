using DataAccessLayer;
using System;


namespace BusinessLayer
{
    internal class clsUserTokensBusiness
    {
        enum enMode { eAddMode = 0, eUpdateMode = 1 };
        enMode _mode;

        public int TokenID { get; private set; }
        public int UserID { get; set; }
        public string TokenValue { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime ExpirationDate { get; private set; }

        public clsUserTokensBusiness()
        {
            this.TokenID = -1;
            this.UserID = -1;
            this.TokenValue = Guid.NewGuid().ToString().Replace("-", "").ToLower();
            this.CreatedDate = DateTime.MinValue;
            this.ExpirationDate = DateTime.MinValue;
            this._mode = enMode.eAddMode;
        }
        clsUserTokensBusiness(int TokenID, int UserID, string TokenValue, DateTime CreatedDate, DateTime ExpirationDate)
        {
            this.TokenID = TokenID;
            this.UserID = UserID;
            this.TokenValue = TokenValue;
            this.CreatedDate = CreatedDate;
            this.ExpirationDate = ExpirationDate;
            this._mode = enMode.eUpdateMode;
        }

        private bool _AddNewToken()
        {
            this.CreatedDate = DateTime.Now;
            this.ExpirationDate = this.CreatedDate.AddDays(7);

            this.TokenID = clsUserTokensDataAccess.AddNewToken(this.UserID, this.TokenValue, this.CreatedDate, this.ExpirationDate);

            return (this.TokenID != -1);
        }

        public static clsUserTokensBusiness FindByUserID(int UserID)
        {
            int TokenID = -1;
            string TokenValue = "";
            DateTime CreatedDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;

            if (clsUserTokensDataAccess.FindByUserID(ref TokenID, UserID, ref TokenValue, ref CreatedDate, ref ExpirationDate))
                return new clsUserTokensBusiness(TokenID, UserID, TokenValue, CreatedDate, ExpirationDate);
            else
                return null;
        }

        public static clsUserTokensBusiness FindByTokenID(int TokenID)
        {
            int UserID = -1;
            string TokenValue = "";
            DateTime CreatedDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;

            if (clsUserTokensDataAccess.FindByTokenID(TokenID, ref UserID, ref TokenValue, ref CreatedDate, ref ExpirationDate))
                return new clsUserTokensBusiness(TokenID, UserID, TokenValue, CreatedDate, ExpirationDate);
            else
                return null;
        }

        public static clsUserTokensBusiness FindByTokenValue(string TokenValue)
        {
            int TokenID = -1, UserID = -1;
            DateTime CreatedDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;

            if (clsUserTokensDataAccess.FindByTokenValue(ref TokenID, ref UserID, TokenValue, ref CreatedDate, ref ExpirationDate))
                return new clsUserTokensBusiness(TokenID, UserID, TokenValue, CreatedDate, ExpirationDate);
            else
                return null;
        }

        public static bool SetTokenExpired(string TokenValue)
        {
            return clsUserTokensDataAccess.SetTokenExpired(TokenValue);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case enMode.eAddMode:
                    if (_AddNewToken())
                    {
                        _mode = enMode.eUpdateMode;
                        return true;
                    }
                    else
                        return false;

                case enMode.eUpdateMode:
                    return false;

                default: return false;
            }
        }

    }
}
