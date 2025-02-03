namespace UserManagementAPI.Configuration
{
  public class MySQLConfig
  {
      public string? Host { get; set; }
      public string? Port { get; set; }
      public string? Name { get; set; }
      public string? User { get; set; }
      public string? Password { get; set; }
  }
  public class JWTConfig
  {
      public string? Secret { get; set; }
  }
}
