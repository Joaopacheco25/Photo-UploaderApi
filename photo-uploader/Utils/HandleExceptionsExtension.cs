

using System;

namespace photo_uploader.Utils
{
    public static  class HandleExceptionsExtension
    {
        public static void EntityHandleException(this bool isEntityNull)
        {
            if (isEntityNull)
            { 
                throw new ArgumentNullException("entity must not be null");
            }
        }
    }
}