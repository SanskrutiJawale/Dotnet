/*class Bill{
    Item [] items;
    int [] quantities;
    float totalAmount;

    public void AddItem(Item item, int quantity){
        if(items == null){
            items = new Item[1];
            items[0] = item;
            quantities = new int[1];
            quantities[0] = quantity;
        }else{
            Item [] temp = new Item[items.Length + 1];
            int [] tempQuantities = new int[quantities.Length + 1];
            for(int i = 0; i < items.Length; i++){
                temp[i] = items[i];
                tempQuantities[i] = quantities[i];
            }
            temp[temp.Length - 1] = item;
            tempQuantities[tempQuantities.Length - 1] = quantity;
            items = temp;
            quantities = tempQuantities;
        }
        totalAmount += item.Price * quantity;
    }

    public void PrintBill()
    {
        Console.WriteLine("-------------------Bill-------------------");
        Console.WriteLine("Id\tName\t\tPrice\tQuantity\tAmount");
        for(int i = 0; i < items.Length; i++){
            Console.WriteLine($"{items[i].Id}\t{items[i].Name}\t\t{items[i].Price}\t{quantities[i]}\t\t{items[i].Price * quantities[i]}");
        }
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Total Amount: {totalAmount}");
        Console.WriteLine("------------------------------------------");
    }

}*/