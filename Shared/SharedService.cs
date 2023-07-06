using Microsoft.Extensions.Configuration;

public class ApiConfigService {
    private readonly IConfiguration _config;
    public ApiConfigService(IConfiguration config) {
        _config = config;
    }

    public int getPort() {
        int port = _config.GetValue<int>("AppSettings:Port");
        return port;
    }
}