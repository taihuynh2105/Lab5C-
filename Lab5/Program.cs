using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class UserAccount
    {
        public string name;
        public int rank;
        public float winRate;
        public string type;
        public int skin;

        public UserAccount(string _name, int _rank, float _winRate, string _type, int _skin)
        {
            name = _name;
            rank = _rank;
            winRate = _winRate;
            type = _type;
            skin = _skin;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*a/ Tạo list UserAccount gồm nhiều hơn 5 item, và xuất dữ liệu ra màn hình */
            Console.OutputEncoding = Encoding.UTF8;
            List<UserAccount> list = new List<UserAccount>();
            list.Add(new UserAccount("Sơn Tùng        ", 10, 55.5f, "Ca nhạc", 50));
            list.Add(new UserAccount("Đen Vâu         ", 5, 70, "Ca nhạc", 10));
            list.Add(new UserAccount("Thuỳ Linh       ", 15, 45.5f, "Ca nhạc", 25));
            list.Add(new UserAccount("Độ Mixi         ", 1, 90, "All", 2));
            list.Add(new UserAccount("Bà Tuyết Diamond", 3, 60.5f, "Ẩm thực", 10));
            list.Add(new UserAccount("PewPew          ", 4, 55.5f, "Live", 50));
            list.Add(new UserAccount("Liên Minh       ", 2, 85.5f, "Game", 255));
            list.Add(new UserAccount("Liên Quân       ", 11, 30.5f, "Game", 200));
            list.Add(new UserAccount("Fifa 4          ", 7, 55.5f, "Game", 150));
            list.Add(new UserAccount("CSO             ", 8, 20, "Game", 1000));
            list.Add(new UserAccount("CSGO            ", 6, 85.5f, "Game", 500));

            Console.WriteLine("Danh sách UserAccount ban đầu");
            foreach (var user in list)
            {
                Console.WriteLine("Name: " + user.name + " | Rank: " + user.rank + " | Tỉ lệ chiến thắng: " + user.winRate + " | Thể loại: " + user.type + " | Skin: " + user.skin);
        }

            /*b/ Sắp xếp danh sách UserAccount theo “Rank” giảm dần*/
            var sortedByRank = list.OrderByDescending(u => u.rank).ToList();
            Console.WriteLine("\nDanh sách UserAccount theo 'Rank' giảm dần");
            foreach (var user in sortedByRank)
            {
                Console.WriteLine("Name: " + user.name + " | Rank: " + user.rank + " | Tỉ lệ chiến thắng: " + user.winRate + " | Thể loại: " + user.type + " | Skin: " + user.skin);
        }

            /*c/ Sắp xếp danh sách UserAccount theo “Name” và “Skin” giảm dần*/
            var sortedByNameAndSkin = list.OrderByDescending(u => u.name).ThenByDescending(u => u.skin).ToList();
            Console.WriteLine("\nDanh sách UserAccount theo 'Name' và 'Skin' giảm dần");
            foreach (var user in sortedByNameAndSkin)
            {
                Console.WriteLine("Name: " + user.name + " | Rank: " + user.rank + " | Tỉ lệ chiến thắng: " + user.winRate + " | Thể loại: " + user.type + " | Skin: " + user.skin);
        }

            /*d/ Liệt kê danh sách các người có Name bắt đầu bằng ký tự “B”*/
            var sortedByNameB = list.Where(u => u.name.StartsWith("B")).ToList();
            Console.WriteLine("\nDanh sách UserAccount có tên bắt đầu bằng chữ B");
            foreach (var user in sortedByNameB)
            {
                Console.WriteLine("Name: " + user.name + " | Rank: " + user.rank + " | Tỉ lệ chiến thắng: " + user.winRate + " | Thể loại: " + user.type + " | Skin: " + user.skin);
        }

            /*Bài 2*/
            /*2a/ Xuất ra màn hình danh sách các người có “WinRate” > 50*/
            var sortedByWinRate50 = list.Where(u => u.winRate > 50f).ToList();
            Console.WriteLine("\nDanh sách các UserAccount có WinRate > 50");
            foreach (var user in sortedByWinRate50)
            {
                Console.WriteLine("Name: " + user.name + " | Rank: " + user.rank + " | Tỉ lệ chiến thắng: " + user.winRate + " | Thể loại: " + user.type + " | Skin: " + user.skin);
            }

            /*b/ Tìm người có WinRate cao nhất*/
            var sortedHighWinRate = list.OrderByDescending(u => u.winRate).FirstOrDefault();
            Console.WriteLine("\nNgười có WinRate cao nhất là: ");
            if (sortedHighWinRate != null)
            {
                Console.WriteLine("Name: " + sortedHighWinRate.name + " | Rank: " + sortedHighWinRate.rank + " | Tỉ lệ chiến thắng: " + sortedHighWinRate.winRate + " | Thể loại: " + sortedHighWinRate.type + " | Skin: " + sortedHighWinRate.skin);

        }

        /*c/ Cho biết danh sách UserAccount có bao nhiêu tài khoản?*/
        Console.WriteLine("\nSố tài trong danh sách UserAccount là: " + list.Count);

            /*3Dùng LINQ ToLookup() chuyển danh sách List< UserAccount > về định dạng 
              kiểu key/Count theo “Type” và xuất toàn bộ thông tin ra màn hình*/
            var lookupByType = list.ToLookup(u => u.type);
            Console.WriteLine("\nThông tin theo từng 'Type' của người chơi trong danh sách:");
            foreach (var item in lookupByType)
            {
                Console.WriteLine("\nType: " + item.Key, item.Count());
                foreach (var user in item)
                {
                    Console.WriteLine("Name: " + user.name + " | Rank: " + user.rank + " | Tỉ lệ chiến thắng: " + user.winRate + " | Thể loại: " + user.type + " | Skin: " + user.skin);
            }
            }

        }
    }