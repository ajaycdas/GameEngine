using GameEngineAPI.Models;

namespace GameEngineAPI.Utilities
{
    public static class DataConstants
    {
        private static List<UserInfo> _userInfos = new List<UserInfo>() {
                new UserInfo(){ Username = "player", Password = "player", Roles = new List<Role>{ Role.Player} },
                new UserInfo(){ Username = "admin", Password = "admin", Roles = new List<Role>{ Role.Player, Role.Admin} }
            };

        public static List<UserInfo> UserInfos { get { return _userInfos; } }
    }
}
