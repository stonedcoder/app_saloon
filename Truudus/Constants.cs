namespace Truudus
{
    class Constants
    {
        #region bases
        private const string baseUrl                = "http://localhost:80/";        
        private const string baseTwo                = "http://localhost:80";
        private const string geobase                = "https://maps.googleapis.com/maps/api/geocode/json?latlng={0},{1}&key=";

        private const string privateKey             = "h8mDq5YIF1SWNHkArGmw";
        private const string publicKey              = "rQ9P5YLnqt8JEmarbyoo";

        private const string apiKey                 = "AIzaSyBu5-1WPBPeyqEPCdG7EBnAxJR4n8HqiGM";
        private const int otplim                    = 6;
        #endregion


        #region Calls
        private const string salreg                 = baseUrl + "regSalon";
        private const string salcom                 = baseUrl + "salComment";
        private const string reguse                 = baseUrl + "regUser";
        private const string login                  = baseUrl + "login";
        private const string incom                  = baseUrl + "salComment";
        private const string geoco                  = geobase + apiKey;
        private const string verif                  = baseUrl + "verify";
        private const string upuser                 = baseUrl + "updateUserPassword";
        private const string updsal                 = baseUrl + "updateSalonPassword";
        private const string upload                 = baseUrl + "upload";
        private const string imghelp                = baseTwo;

        internal const string SALREG                = salreg;
        internal const string SALCOM                = salcom;
        internal const string REGUSE                = reguse;
        internal const string LOGIN                 = login;
        internal const string INCOM                 = incom;
        internal const string GEOCO                 = geoco;
        internal const string VERIF                 = verif;
        internal const string UPUSER                = upuser;
        internal const string UPDSAL                = updsal;
        internal const string UPLOAD                = upload;
        internal const string IMGHELP               = imghelp;
        #endregion

        #region Get them
        private const string getuser                = baseUrl + "getUser";
        private const string getcom                 = baseUrl + "getComments";
        private const string getsal                 = baseUrl + "searchSaloon";

        internal const string GETUSER               = getuser;
        internal const string GETCOM                = getcom;
        internal const string GETSAL                = getsal;

        internal const int OTPLIM                   = otplim;
        #endregion                

        #region Encryption
        private const string priv                   = privateKey + "PePvTs4Ks9Xxa9kqpJsc";
        private const string pub                    = publicKey + "YibRd1eBb71FnwAn93xI";

        internal const string PRIVATEKEY            = priv;
        internal const string PUBLICKEY             = pub;
        #endregion
    }
}
