// See https://aka.ms/new-console-template for more information



using System;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.Emit;
using System.Xml.Linq;

partial class Program
{


    static void Main(string[] args)
    {
        Console.Write("\n");
        Console.WriteLine("마을 입구에서부터 활기 넘치는 분위기의 마을.\n");
        Console.WriteLine("[ 푸크 마을에 오신 여러분 환영합니다. ]");
        Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.\n");

        Console.Write("\n");
        Console.WriteLine("원하시는 이름을 설정해 주세요.\n");
        Console.WriteLine("플레이어 이름\n");


        string usrName = Console.ReadLine();
        Console.WriteLine("\n입력하신 이름은 " + usrName + " 입니다.\n");

        string job = "";

        while (true)
        {
            Console.WriteLine("직업을 선택해 주세요");
            Console.WriteLine("1. 전사");
            Console.WriteLine("2. 마법사");
            Console.WriteLine("3. 궁수");
            Console.WriteLine("4. 성직자");
            Console.WriteLine("5. 도적");



            switch (Console.ReadLine())
            {
                case "1":
                    job = "전사";
                    break;
                case "2":
                    job = "마법사";
                    break;
                case "3":
                    job = "궁수";
                    break;
                case "4":
                    job = "성직자";
                    break;
                case "5":
                    job = "";
                    break;
                default:
                    // 잘못된 입력 시 다시 선택을 요청
                    Console.WriteLine("잘못된 선택입니다. 다시 선택해 주세요.");
                    continue; // 올바른 입력을 받을 때까지 반복
            }

            // 올바른 직업 선택
            Console.WriteLine($"{job}를 선택하셨습니다.");
            break;
        }

        int select;

        while (true) // 반복적인 메뉴 While
        {
            // 메뉴 표시
            Console.Clear();
            Console.Write("\n");
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("4. 던전 입장");
            Console.WriteLine("5. 휴식하기");
            Console.WriteLine("6. 게임 저장");
            Console.Write("원하시는 행동을 입력해 주세요: ");
            string input = Console.ReadLine();
            select = int.Parse(input);


            switch (select)
            {
                case 1:
                    ShowStatus();
                    break;

                case 2:
                    Console.WriteLine("인벤토리 메뉴로 이동합니다.");
                    break;

                case 3:
                    Console.WriteLine("상점으로 이동합니다.");
                    break;

                case 4:
                    Console.WriteLine("던전 입장합니다.");
                    break;

                case 5:
                    Console.WriteLine("휴식하기.");
                    break;

                case 6:
                    Console.WriteLine("게임 저장.");
                    break;



                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }

            // 계속해서 선택을 할 수 있게 처리
            Console.WriteLine("계속하려면 아무 키나 누르세요.");
            Console.ReadKey();
        }
    }


    // 상태 보기 화면 출력 함수
    static void ShowStatus()
    {
        // 상태 보기
        Console.Clear();
        Console.WriteLine("상태 보기");
        Console.WriteLine("캐릭터의 정보가 표시됩니다.");
        Console.WriteLine();

        string job = "전사";
       


        if (job == "전사")
        {
            Console.WriteLine("Lv. 01");
            Console.WriteLine("Chad (전사)");
            Console.WriteLine("공격력 : 10");
            Console.WriteLine("방어력 : 5");
            Console.WriteLine("체력 : 100");
            Console.WriteLine("Gold : 1500 G");
        }
        else if (job == "마법사")
        {
            Console.WriteLine("Lv. 01");
            Console.WriteLine("Chad (마법사)");
            Console.WriteLine("공격력 : 5");
            Console.WriteLine("방어력 : 10");
            Console.WriteLine("체력 : 60");
            Console.WriteLine("마법력 : 100");
            Console.WriteLine("Gold : 1500 G");
        }
        else if (job == "궁수")
        {
            Console.WriteLine("Lv. 01");
            Console.WriteLine("Chad (궁수)");
            Console.WriteLine("공격력 : 8");
            Console.WriteLine("방어력 : 15");
            Console.WriteLine("체력 : 70");
            Console.WriteLine("민첩성 : 100");
            Console.WriteLine("Gold : 1500 G");
        }
        else if (job == "성직자")
        {
            Console.WriteLine("Lv. 01");
            Console.WriteLine("Chad (성직자)");
            Console.WriteLine("공격력 : 4");
            Console.WriteLine("방어력 : 18");
            Console.WriteLine("체력 : 90");
            Console.WriteLine("치유력 : 100");
            Console.WriteLine("Gold : 1500 G");
        }
        else if (job == "도적")
        {
            Console.WriteLine("Lv. 01");
            Console.WriteLine("Chad (도적)");
            Console.WriteLine("공격력 : 12");
            Console.WriteLine("방어력 : 10");
            Console.WriteLine("체력 : 80");
            Console.WriteLine("운 : 100");
            Console.WriteLine("Gold : 1500 G");
        }

        Console.WriteLine("\n");
        Console.WriteLine("0. 나가기");
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.Write(">>");

        string input = Console.ReadLine();

        if (input == "0")
        {
            Console.WriteLine("나가고 있습니다.");
        }
        else
        {
            Console.WriteLine("잘못된 입력입니다.");
        }

        Console.WriteLine("계속하려면 아무 키나 누르세요.");
        Console.ReadKey();

    }

    public class Item
    {
        public string ItemName { get; set; }
        public string ToolTip { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Price { get; set; }
        public bool Purchase { get; set; } // True if item is purchased

        public Item(string itemName, string toolTip, int attack, int defense, int price)
        {
            ItemName = itemName;
            ToolTip = toolTip;
            Attack = attack;
            Defense = defense;
            Price = price;
            Purchase = false;
        }
    }



    public class Game
    {
        public int Gold { get; set; }

        public Game(int initialGold)
        {
            Gold = initialGold;
        }

        public void Store()
        {
            Console.Clear();
            Console.WriteLine("[ 상점 ]\n보유 중인 아이템을 관리 할 수 있습니다.\n");
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{Gold} G\n");

            List<Item> items = new List<Item>  // 아이템 리스트
            {
                new Item("수련자 갑옷", "방어력 +5 | 수련에 도움을 주는 갑옷입니다.", 0, 5, 1000),
                new Item("무쇠 갑옷", "방어력 +9 | 무쇠로 만들어져 튼튼한 갑옷입니다.", 0, 9, 2000),
                new Item("스파르타의 갑옷", "방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 0, 15, 3500),
                new Item("낡은 검", "공격력 +2 | 쉽게 볼 수 있는 낡은 검입니다.", 2, 0, 500),
                new Item("청동 도끼", "공격력 +5 | 어디선가 사용됐던 도끼입니다.", 5, 0, 1500),
                new Item("스파르타의 창", "공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.", 7, 0, 2500)
            };

            Console.WriteLine("[ 아이템 목록 ]");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].ItemName} | {items[i].ToolTip} | {items[i].Price}G{(items[i].Purchase ? " - 구매 완료" : "")}");

            }

            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.\n");
            Console.WriteLine("0. 나가기\n1. 아이템 구매");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int storeInput))
                {
                    switch (storeInput)
                    {
                        case 0:
                            Console.WriteLine("상점을 종료합니다.");
                            return;

                        case 1:
                            BuyItem(items);
                            break;

                        default:
                            Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                            break;

                    }
                }
            }
        }

        private void BuyItem(List<Item> items)
        {
            throw new NotImplementedException();
        }

        public void Inventory() 
        {
            Console.Clear();
            Console.WriteLine("[ 인벤토리 ]\n보유 중인 아이템을 관리 할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]\n");

            Console.WriteLine(" 원하시는 행동을 입력해주세요.\n");
            Console.WriteLine(" 0. 나가기\n 1. 장착 관리\n");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int invenInput)) // 0,1 중에 택1
                {
                    if (invenInput == 0)
                    {
                        getSelect(); 
                        break;
                    }
                    else if (invenInput == 1)
                    {
                        WearItem(); 
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.  숫자만 입력하세요.");
                    }
                }
            }
        }


        public void Rest(Player player)
        {
            Console.Clear();
            Console.WriteLine($" 500 G 를 내면 체력을 회복할 수 있습니다. (보유 골드 : {player.Gold} G)\n");
            Console.WriteLine("1. 휴식하기 // 0. 나가기");

            string input = Console.ReadLine();

            if (input == "0")
            {
                getSelect(player);
                return; // Rest() 
            }

            if (input == "1") // 휴식을 선택한 경우
            {
                if (player.Gold >= 500) // 골드가 500 이상 있을 시.
                {
                    player.Gold -= 500; // -500골드
                    player.Hp = 100; // 체력을 100까지 회복
                    Console.WriteLine($"휴식을 완료했습니다. (보유 골드 : {player.Gold} G)");
                }
                else
                {
                    Console.WriteLine("Gold가 부족합니다.");
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
            Console.WriteLine("\n아무 키나 누르면 돌아갑니다.");
            Console.ReadLine(); 
            getSelect(player); 
            return;
        }

        private void getSelect(Player player)
        {
            throw new NotImplementedException();
        }

        private void getSelect()
        {
            throw new NotImplementedException();
        }

        public void WearItem()  
        {
            Console.Clear();
            Console.WriteLine("test");
        }

        public class Player
        {
            public int Gold { get; internal set; }
            public int Hp { get; internal set; }
        }
    }
    interface IDungeon
    {
        int RecommendedShield { get; }

        int DefaultReward { get; }

        void FailedDungeon();

        void ClearDungeon();
    }



}

