using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Instagram.Infrastructure.Data.Models;

namespace Instagram.Infrastructure.Data.Constants
{
    public static class DbConstants
    {
        public static class UserConstants
        {
            
            public const int UserNameMaxLenght = 50;
            public const int EmailMaxLenght = 150;
            public const int BioMaxLenght = 200;
             
        }


        public static class PostConstants
        {
            
            public const int ContentMaxLenght = 500;
            public const int EmailMaxLenght = 150;
            public const int BioMaxLenght = 200;
             


        }

        public static class MessageConstants
        {
            
            public const int ContentMaxLenght = 150;

             


        }

    }
}