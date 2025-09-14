public class Program{
    public static void Main(string[] args)
    {
        // bài tập cho biến bằng 1 thì vô nghiệm 
        Console.WriteLine("Nhập giá trị bạn muốn điền");
        Double a = Convert.ToDouble(Console.ReadLine());
        if (a >= 8)
        {
            Console.WriteLine("Học sinh giỏi");
        }
        else if (a >= 6.5)
        {
            Console.WriteLine("Học sinh khá"); 
        }
        else if (a >= 5)
        {
            Console.WriteLine("Học sinh trung bình"); 
        }
        else
        {
            Console.WriteLine("Chưa đạt");
        }
        
    }
}
