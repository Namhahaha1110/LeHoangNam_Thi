using static LeHoangNam_ThiFinalTest.LinkedList;

class Program
{

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        BinarySearchTree dictionary = new BinarySearchTree();
        bool exit=false;

        while(!exit)
        {
            
            Console.WriteLine("==== Quản lý từ điển Anh – Việt ====");
            Console.WriteLine("1. Thêm từ mới");
            Console.WriteLine("2. Tìm kiếm từ");
            Console.WriteLine("3. In danh sách từ");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn chức năng (1-4): ");
            string choice =Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Nhập từ tiếng anh: ");
                    string englishWord=Console.ReadLine();
                    Console.Write("Nhập nghĩa tiếng Việt: ");
                    string meaning=Console.ReadLine();
                    dictionary.AddWord(englishWord, meaning);
                    break;
                case "2":
                    Console.Write("Nhập từ tiếng anh cần tìm: ");
                    string searchWord=Console.ReadLine();
                    dictionary.SearchWord(searchWord);
                    break;
                case "3":
                    Console.Write("Danh sách từ trong từ điển: ");
                    dictionary.PrintDictionary();                 
                    break;
                case "4":
                    Console.WriteLine("Thoát chương trình...");
                    exit=true;
                    break;
                default:
                    Console.WriteLine("Chọn chức năng không hợp lệ!");
                    break;
            }
        } 
    }
  
}
