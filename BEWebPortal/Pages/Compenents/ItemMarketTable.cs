namespace BEWebPortal;

public struct ItemMarketTable
{
    public ItemMarketTable(String itemID, String itemName)
    {
        this.itemID = itemID;
        this.itemName = itemName;
    }
    public String itemID { get; set; }
    public String itemName { get; set; }
    public double[] itemHist { get; set; }
}