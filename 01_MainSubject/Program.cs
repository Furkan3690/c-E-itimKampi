using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Basit Hesap Makinesine Hoş Geldiniz!");

        // İlk sayıyı kullanıcıdan al
        Console.Write("Lütfen ilk sayıyı giriniz: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // İkinci sayıyı kullanıcıdan al
        Console.Write("Lütfen ikinci sayıyı giriniz: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // İşlem türünü kullanıcıdan al
        Console.WriteLine("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Yeni satıra geç

        // İşlem sonucunu hesapla ve ekrana yazdır
        switch (operation)
        {
            case '+':
                Console.WriteLine($"Sonuç: {num1} + {num2} = {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"Sonuç: {num1} - {num2} = {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"Sonuç: {num1} * {num2} = {num1 * num2}");
                break;
            case '/':
                if (num2 != 0)
                {
                    Console.WriteLine($"Sonuç: {num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Bir sayıyı 0'a bölemezsiniz!");
                }
                break;
            default:
                Console.WriteLine("Geçersiz bir işlem seçtiniz.");
                break;
        }

        // Kullanıcıyı bilgilendir ve uygulamayı sonlandır
        Console.WriteLine("Hesaplama tamamlandı. Programdan çıkmak için bir tuşa basın.");
        Console.ReadKey();
    }
}
