using CPProject.DataBaseModel.types;

namespace CPProject.DataBaseModel.entities
{
    public class SimpleUser : User
    {
        public SimpleUser(string id, string login, string password,
            DateTime birthdayDate, UserType userType) : base(id, login, password, birthdayDate, userType) { }
    }
}
