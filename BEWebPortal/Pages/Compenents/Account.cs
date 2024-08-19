namespace BEWebPortal;

public struct Account
{
    public String uuid { get; set; }
    public String username { get; set; }
    public bool locked { get; set; }
    public long money { get; set; }
    public string moneyFormatted { get; set; }
}