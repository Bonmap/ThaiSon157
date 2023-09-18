class program
{
    static void Main(string[] args)
    {
        // Khởi tạo thông tin khung trò chơi, điểm số
        Console.Clear();
        int chieu_dai_man = 20;
        int chieu_rong_man = 8;
        int so_diem = 0;

        // Khởi tạo vị trí ban đầu của rắn
        Random vitringaunhien = new Random();
        int x_ran = vitringaunhien.Next(1, 19);
        int y_ran = vitringaunhien.Next(1, 7);

        // Khởi tạo vị trí ban đầu của mồi, đảm bảo khác vị trí của rắn
        int x_moi = vitringaunhien.Next(1, 19);
        int y_moi = vitringaunhien.Next(1, 7);
        do
        {
            if (x_moi == x_ran & y_moi == y_ran)
            {
                x_moi = vitringaunhien.Next(1, 19);
                y_moi = vitringaunhien.Next(1, 7);
            }
        } while (x_moi == x_ran & y_moi == y_ran);

        // Khởi tạo vị trí tạm thời của rắn
        int x_ran_tam = 0;
        int y_ran_tam = 0;


        // Tạo vòng lặp để chơi game giúp rắn di chuyển trong khung
        bool dang_choi = true;

        // Vẽ khung màn chơi

        do
        {
            Console.BackgroundColor = ConsoleColor.Red; // Tạo màu nền
            // Vẽ đường trên
            for (int i = 0; i < chieu_dai_man; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("%");
            }
            // Vẽ đường dưới
            for (int i = 0; i < chieu_dai_man; i++)
            {
                Console.SetCursorPosition(i, chieu_rong_man - 1);
                Console.Write("%");
            }
            // Vẽ đường bên trái
            for (int i = 1; i < chieu_rong_man - 1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("%");
            }
            // Vẽ đường bên phải
            for (int i = 1; i < chieu_rong_man - 1; i++)
            {
                Console.SetCursorPosition(chieu_dai_man - 1, i);
                Console.Write("%");
            }

            //Hiển thị điểm số:
            Console.SetCursorPosition(30, 4);
            Console.BackgroundColor = ConsoleColor.Blue;// Tạo màu nền
            Console.ForegroundColor = ConsoleColor.Red;// Tạo màu chữ
            Console.Write("So diem cua ban:" + so_diem);

            // Vẽ rắn
            Console.BackgroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x_ran, y_ran);
            Console.Write(" ");

            // Vẽ mồi 
            Console.ResetColor();
            Console.SetCursorPosition(x_moi, y_moi);
            Console.Write("o");
            Console.SetCursorPosition(0, 9);

            // thông tin người nhập vào
            ConsoleKeyInfo dulieudauvao = Console.ReadKey();
            if (dulieudauvao.Key == ConsoleKey.UpArrow)
            {
                x_ran_tam = x_ran;
                y_ran_tam = y_ran - 1;
            }
            else if (dulieudauvao.Key == ConsoleKey.DownArrow)
            {
                x_ran_tam = x_ran;
                y_ran_tam = y_ran + 1;
            }
            else if (dulieudauvao.Key == ConsoleKey.LeftArrow)
            {
                x_ran_tam = x_ran - 1;
                y_ran_tam = y_ran;
            }
            else if (dulieudauvao.Key == ConsoleKey.RightArrow)
            {
                x_ran_tam = x_ran + 1;
                y_ran_tam = y_ran;
            }
            // Xóa vị trí rắn cũ
            Console.SetCursorPosition(x_ran, y_ran);
            Console.Write(" ");

            // Cập nhật vị trí rắn mới
            x_ran = x_ran_tam;
            y_ran = y_ran_tam;

            // Vẽ rắn mới
            Console.BackgroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x_ran, y_ran);
            Console.Write(" ");

            // Rắn ăn được mồi (xóa mồi cũ, cộng điểm và tạo mồi mới)
            // Xóa mồi cũ và cộng điểm
            if (x_ran == x_moi & y_ran == y_moi)
            {
                Console.SetCursorPosition(x_moi, y_moi);
                Console.Write(" ");
                so_diem++;
            }
            //tạo mồi mới, đảm bảo khác vị trí rắn
            do
            {
                if (x_moi == x_ran & y_moi == y_ran)
                {
                    x_moi = vitringaunhien.Next(1, 19);
                    y_moi = vitringaunhien.Next(1, 7);
                }
            } while (x_moi == x_ran & y_moi == y_ran);

            Console.SetCursorPosition(x_moi, y_moi);
            Console.Write("o");

            // Rắn chạm khung kết thúc vòng lặp chơi game
            if (x_ran < 1 || x_ran >= chieu_dai_man - 1 || y_ran < 1 || y_ran >= chieu_rong_man - 1)
            {
                dang_choi = false;
            }

        } while (dang_choi);

        // Hiện thị kết thúc trò chơi
        Console.SetCursorPosition(x_ran, y_ran);
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("chet toi roi");

        Console.SetCursorPosition(0, 9);
        Console.ResetColor();
    }
}