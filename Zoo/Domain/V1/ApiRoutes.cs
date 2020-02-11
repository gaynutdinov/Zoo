using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Domain.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Animals
        {
            public const string GetAll = Base + "/GetAllAnimals";

            public const string Get = Base + "/GetAnimal/{postId}";

            public const string Update = Base + "/UpdateAnimal/{postId}";

            public const string Delete = Base + "/DeleteAnimal/{postId}";

            public const string Create = Base + "/CreateAnimal";
        }

        public static class Employees
        {
            public const string GetAll = Base + "/GetAllEmployees";

            public const string Get = Base + "/GetEmployee/{postId}";

            public const string Update = Base + "/UpdateEmployee/{postId}";

            public const string Delete = Base + "/DeleteEmployee/{postId}";

            public const string Create = Base + "/CreateEmployee";
        }

        public static class EARelations
        {
            public const string GetAll = Base + "/GetAllEARelations";

            public const string Get = Base + "/GetEARelation/{postId}";

            public const string Update = Base + "/UpdateEARelation/{postId}";

            public const string Delete = Base + "/DeleteEARelation/{postId}";

            public const string Create = Base + "/CreateEARelation";
        }

        public static class Identity
        {
            public const string Login = Base + "/identity/login";

            public const string Register = Base + "/identity/register";

            public const string Refresh = Base + "/identity/refresh";
        }
    }
}
