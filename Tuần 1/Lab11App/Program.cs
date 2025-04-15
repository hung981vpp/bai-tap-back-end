/*Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
[tên], bạn[tuổi] tuổi!".*/
Console.OutputEncoding = System.Text.Encoding.UTF8;
//string? ten;
//int? tuoi;

//Console.Write("Nhập tên: ");
//ten = Console.ReadLine();
//Console.Write("Nhập tuổi: ");
//tuoi = int.Parse(Console.ReadLine() ?? "0");
////in ra màn hình
//Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");

/*
 Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và
chiều rộng.
 */
double chieuDai, chieuRong, dienTich;
try
{
    Console.Write("Nhập chiều dài: ");
    chieuDai = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Nhập chiều rộng: ");
    chieuRong = double.Parse(Console.ReadLine() ?? "0");
    if(chieuDai <= 0 || chieuRong <= 0)
        throw new Exception("Độ dài phải lớn hơn 0");
    //tính diện tích
    dienTich = chieuDai * chieuRong;
    Console.WriteLine($"Diện tích là: {dienTich}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Lỗi nhập liệu: {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
