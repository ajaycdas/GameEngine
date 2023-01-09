namespace GameEngineAPI.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public List<Role>? Roles { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
