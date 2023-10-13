namespace _1722_динамічна_бібліотека
{
    public class Bills
    {
        private static int index = 0;
        public int id_currency { get; set;}
        public int id_account_type { get; set; }
        public int id_funds_type { get; set; }
        public int id_institutions { get; set; }
        public int amount_funds { get; set; }
        public string note { get; set; }
        Bills(int id_currency_new, int id_account_type_new, int id_funds_type_new, int id_institutions_new, int amount_funds_new)
        {
            index += 1;
            id_currency = id_currency_new;
            id_account_type = id_account_type_new;
            id_funds_type= id_funds_type_new;
            id_institutions = id_institutions_new;
            amount_funds = amount_funds_new;    
        }
        public static int GetIndex()
        {
            return index;
        }
        public void increase(int number)
        {
            amount_funds += number;
        }
        public void reduction(int number)
        {
            amount_funds -= number;
        }
        
    }    
}