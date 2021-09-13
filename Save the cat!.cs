//此程式為小組作品

using System;
using static System.Console;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace main
{
    class Program
    {
        private static string player = "";
        private static string cat = "";
        private static char tarotaorb = ' ';
       
        public static void Main(string[] args)
        {   ///設為公共

            {
                Write("輸入您的名子: ");
                player = ReadLine();
                Write("輸入貓的名子: ");
                cat = ReadLine();
                WriteLine("遊戲進行中，請按Enter鍵繼續遊戲。 "); ReadLine();
            }
            {
            }
            {
                Program.Chapter0(player, cat,out tarotaorb);
                Program.Chapter1(player, cat);
                Program.Chapter2(player, cat);
                Program.Chapter3(player, cat);
                Program.Chapter4(player, cat, tarotaorb);
            }
        }
        //========All story============
        public static void Chapter0(string player, string cat,out char tarotaorb)
        {

            {
                WriteLine("" +
                "\t歡迎來到 貓咪共和國\n" +
                "\t不需要簽證入境 我只要你說\n" +
                "\t你會永遠伺候我\n" +
                "\t你會永遠愛著我\n" +
                "\t貓咪共和國 by 韋禮安"); ReadLine();
                WriteLine("\tChapter 0 allegory"); ReadLine();

                Write("在夢裡，你在走一個構造簡單的迷宮，你隱約知道會進入這裡只因為真實世界所構成的迷宮比這複雜太多了，"); ReadLine();
                Write("所以你逃入這個可以輕易找到出口的地方。"); ReadLine();
            }
            Program.Maze();
            SetCursorPosition(0, CursorTop + 12);//maze的光標回歸原位
            {
                {
                    WriteLine("你抵達了出口。"); ReadLine();
                    WriteLine("占卜師: {0}...心中想著你的問題，讓自己安靜下來，然後請你選出一張牌。", player); ReadLine();
                    WriteLine("A. 牌面上是黑夜，畫面中央有一個巨型櫥櫃，櫥櫃著火了有一個人正頭下腳上的往下墜，表情看起來像是畫\n" +
                        "   作「吶喊」，有一隻貓咪跟在人的後面跳下來..."); ReadLine();
                    WriteLine("B.一個穿著斗篷的人形騎在馬上，他一手拿著殺蟲劑，一手拿著百合花，不知道是不是園丁來著。有個人抱著\n" +
                        "   貓跪在馬匹前，在畫面背景中是升起的黎明，不...也許那其實是暮色。"); ReadLine();
                }
                Write("選擇A或B?: ");
                tarotaorb = ReadLine().ToCharArray()[0];
                bool ok1 = tarotaorb == 'a' || tarotaorb == 'b' || tarotaorb == 'A' || tarotaorb == 'B';
                while (!ok1)
                {
                    WriteLine("輸入錯誤，請重新輸入: ");
                    tarotaorb = ReadLine().ToCharArray()[0];
                    ok1 = tarotaorb == 'a' || tarotaorb == 'b' || tarotaorb == 'A' || tarotaorb == 'B';
                    if (ok1) break;
                }
                switch (tarotaorb)
                {

                    case 'A':
                    case 'a':
                        WriteLine("\n占卜師: 這是16號，塔牌，高塔想傳遞的訊息是打擊、恐懼。"); ReadLine();
                        WriteLine("{0}:　...", player); ReadLine();
                        WriteLine("占卜師:不過你知道嗎，把高塔牌的數字1與6相加，7號，是戰車牌，戰車所代表的是面對困難時所表現的\n" +
                            "意志力呢"); ReadLine();
                        WriteLine("占卜師的語調柔和十分柔和，你覺得聽她說話像是走在剛下過雨的草原上，空氣清新好聞。"); ReadLine();
                        WriteLine("\tChapter 0 end\n\n");
                        break;
                    case 'B':
                    case 'b':
                        WriteLine("\n占卜師: 這是13號，死神牌，恩...死神牌的一個訊息和死亡有關。"); ReadLine();
                        WriteLine("{0}:　...", player); ReadLine();
                        WriteLine("占卜師:雖然這可能令人難以接受，但是當死神拿著鐮刀走向一個生命時，它有時也是很難避免的，你也\n" +
                            "可以把它當作命運和新的開始喔"); ReadLine();
                        WriteLine("占卜師的聲音越來越低緩，讓你覺得很安心，好像回歸到大地的懷抱。"); ReadLine();
                        WriteLine("\tChapter 0 end\n\n"); ReadLine();
                        break;
                }
               
            }
        }
        public static void Chapter1(string player, string cat)
        {
            {
                WriteLine("\tChapter 1 astray"); ReadLine();
                WriteLine("「你」從夢境中醒來。渾身是汗，有哪裡不太對勁，你想。剛剛的夢一定是個可怕的夢。看看手機，你知\n" +
                    "道現在是凌晨兩點，才睡不到兩小時，這對總是一覺到天亮的你來說並不尋常。"); ReadLine();
                WriteLine("空氣微微的流動，還因為剛剛的夢感到焦慮的你稍微清醒了一點。"); ReadLine();
                WriteLine("你起身，打開電燈，泡了一杯牛奶加燕麥，燕麥的味道總是能令你安心，在你慢慢的啜著牛奶燕麥時，你\n" +
                    "突然想滑一下手機，你打開手機，卻有點想不起自己的密碼..."); ReadLine();
                WriteLine("手機介面顯示 **** "); ReadLine();
            }
            Program.A1B2(player, cat);
            {
                WriteLine("喝完後，你打算繼續回去睡覺，明天還有早八的課。而躺上床之前，你習慣抱著{0}一起睡，於是往四周到處\n" +
                          "看了一圈，你租下這間不甚寬廣的房間已經一年了，從門的地方開始依序是小客廳、流理臺、橫靠在牆邊的\n" +
                          "單人床，中間並沒有特別的間隔，在你的視線範圍內沒有看到{1}。", cat, cat); ReadLine();
                WriteLine("{0}:{1}呢?", player, cat); ReadLine();
                {
                    Write("你要? A.去浴室看看 B.更仔細地在房間找找。選擇A或B: ");
                    char aorb2 = ReadLine().ToCharArray()[0];
                    bool ok1 = aorb2 == 'a' || aorb2 == 'b' || aorb2 == 'A' || aorb2 == 'B';
                    while (!ok1)
                    {
                        WriteLine("輸入錯誤，請重新輸入: ");
                        aorb2 = ReadLine().ToCharArray()[0];
                        ok1 = aorb2 == 'a' || aorb2 == 'b' || aorb2 == 'A' || aorb2 == 'B';
                        if (ok1) break;
                    }
                    switch (aorb2)
                    {

                        case 'A':
                        case 'a':
                            WriteLine("\n你開了浴室的燈，開門看向裡面。"); ReadLine();
                            WriteLine("{0}不在。{0}的貓砂盆放在牆角。", cat, cat); ReadLine();
                            WriteLine("{0}:順便清一下貓砂盆好了，{1}可能躲在什麼角落吧，等一下再仔細看看。", player, cat);
                            WriteLine("你去清理貓砂盆，{0}現在用的是崩解式木屑沙，你想著過陣子還是換凝結式的好了，印象中之前那一款比較\n" +
                                "不臭。", cat); ReadLine();
                            WriteLine("你把貓砂丟到馬桶裡，丟進馬桶的瞬間，水從中間暈開變成了鮮紅色。"); ReadLine();
                            WriteLine("{0}:..怎麼又這樣...，明天下班要帶牠看醫生才行。你走出浴室。", player); ReadLine();
                            break;
                        case 'B':
                        case 'b':
                            WriteLine("\n{0}: {1}、{2}..",player, cat, cat); ReadLine();
                            WriteLine("{0}:　...", player); ReadLine();
                            WriteLine("你一邊叫著{0}，一邊打開衣櫥，衣櫥裡沒有；站到椅子上往衣櫥上看，上面沒有。",cat); ReadLine();
                            WriteLine("你看向床底，床底沒有" + cat + "，但是有一灘乾掉的嘔吐物。"); ReadLine();
                            WriteLine(player + ":...怎麼總覺得牠最近很常吐，明天要帶牠去看醫生了..."); ReadLine();
                            break;
                    }
                }
                {
                    WriteLine("晚風徐徐的拂向窗簾，你感受到一涼爽的風，看向窗邊。窗簾的一角被掀出一個小小的三角形，窗戶沒關?你\n" +
        "走向窗戶。"); ReadLine();
                    WriteLine("你害怕的事發生了，" + cat + "從窗戶跳出去了。這裡是二樓，往窗戶看出去，沒有看到" + cat + "的身影，能看到的\n" +
                        "各家戶的窗簷高低錯落，塑膠面板在夜色下，顏色是清冷的綠色，一樓停著一些車頂較高的卡車，一隻貓從\n" +
                        "只是二樓屋簷可以輕易地跳上卡車，再跳到一樓。"); ReadLine();
                    WriteLine(cat + "不知道跑去哪裡了，會不會跳到別人家裡的陽台了...?現在是半夜，不可能到處喊" + cat + "的名字...，" + cat + "\n"
                            + "從來沒有在野外求生過，會不會不懂得閃避車輛...?我找的到" + cat + "嗎...?"); ReadLine();
                    WriteLine("你趕忙帶了鑰匙和手機，還穿著有卡通圖案的睡衣，披上風衣就出門了。"); ReadLine();
                    WriteLine("你踏出一樓大門，關上門，轉身。四周的視野看起來不太一樣，街景被誰調成印象派風格，但因為是半夜，\n" +
                              "事物們仍然帶有朦朦朧朧的黑灰色。"); ReadLine();
                    WriteLine("所有的事物現在都由一筆一筆的線條所組成，線條們在緩緩的循環流動著，就像工廠的生產帶。鐵捲門不再是\n" +
                              "純然的灰，貨車也不再是純然的藍，在灰與藍的線條中，揉合了夜光與路燈的白光帶來的銀色線條，比你印象\n" +
                              "中的樣子美麗許多，不過事物似乎也因此失去了邊界，而你走動時線條看起來也像配合你的走動加快了速度，\n" +
                              "你的身體接觸到事物時原本平行流動的線條產生碰撞，有些更細小的線條像蠟筆一樣飛出，混雜著銀光看起來\n" +
                              "就像鐵鎚打在燒紅的烙鐵上時，所迸發的火星。"); ReadLine();
                    WriteLine("比這更奇怪的是，你立刻就接受了這樣奇異的世界，不，應該是說，你現在一心只想找到" + cat + "而已。"); ReadLine();
                    WriteLine("\tChapter 1 end\n\n");
                }
            }
        }
        public static void Chapter2(string player, string cat)
        {
            {
                WriteLine("\tChapter 2 cats"); ReadLine();
                WriteLine(player + ":" + cat + "平常那麼膽小，現在一定很害怕，大概是跳到外面後就跳不回來了吧...這個笨蛋。"); ReadLine();
                WriteLine("經過的每一個車底、盆栽、垃圾堆之間，你都極其仔細的搜索一遍。"); ReadLine();
                WriteLine("就這樣找了幾條巷子，所有東西看起來都很尋常，都是你日常生活中看慣了的事物，出現的活物就只有蟑螂與\n" +
                          "老鼠 ( 附帶一提，蟑螂和老鼠在畫作般的景象下看起來可愛許多，但你仍然遠遠的避開他們)。"); ReadLine();
                WriteLine(player + ":" + cat + "是橘貓，如果牠出現應該蠻明顯的.."); ReadLine();
                WriteLine("在一條寬闊的大街邊，你正準備轉進一條小巷時，你發現某棟公寓的大門敞開著，你突然覺得" + cat + "可能會從\n" +
                          "這裡跑上去，於是你走進這棟公寓。沿著樓梯往上爬，進到門裡後那種愉快明亮的印象派色調消失了，取而\n" +
                          "代之的是陌生的公寓中陰暗斑駁的牆壁與帶著霉味涼颼颼的空氣，這裡一片漆黑，只能藉著外面的路燈透進\n" +
                          "來的光線免強看到階梯，你覺得這樣的氣氛很可怕，但是還是硬著頭皮往前走。雖然目前的景象很可怕，但\n" +
                          "想到" + cat + "，你覺得很著急，怕牠會被什麼人拐走。"); ReadLine();
                WriteLine("爬樓梯時，你隱約看到階梯上到處散布著蟲與蟑螂的屍體。"); ReadLine();
                WriteLine(player + ":噁，還是盡量避開不要踩到..."); ReadLine();
            }

            WriteLine("【您將挑戰遊戲: 踩地雷(>_<)】"); ReadLine();


            SetCursorPosition(0, CursorTop + 21);//Minesweeper的光標回歸原位
            Program.Minesweeper();

            { //ch2後面劇情
                WriteLine("一邊小聲地叫著{0}，你似乎爬到了頂樓，這個地方只有黑漆漆的門框卻沒有門，門框外傳來悉悉簌簌的聲音，\n",cat+
                          "聽起來很像{0}在抱怨時的叫聲，你趕忙走出去。",cat);ReadLine();
                WriteLine("門外是一個沒有屋頂、四周圍圍著稍微高起、只到你腳踝高處、與其稱作是牆、稱作檻更為合適的水泥台階，\n" +
                          "這裡很像是還住在舊家時，常帶{0}上去放風的頂樓，因為沒有屋頂遮蓋，藉由月光，比剛剛在樓梯間看得清\n",cat +
                          "晰的多了。在一個角落有一圈黃澄澄、毛茸茸的、像是立起的俄羅斯娃娃、或是保齡球瓶的東西，你走向前，\n" +
                          "原來是橘貓，而且有五隻，牠們正坐成一圈，隨著你的走近牠們一起回頭看向你。");  ReadLine();
                WriteLine("牠們沒有跑開，但是你還是怕會驚嚇到牠們，所以隔著幾步的距離就蹲下來。");ReadLine();
                WriteLine("{0}:牠們是{1}嗎...不對，{2}只有一個，那...是哪一個?", player,cat,cat); ReadLine();
                WriteLine("有一隻先向你走來，在你的腳邊來回走動，輕輕蹭過你。"); ReadLine();
                WriteLine("{0}:是這隻?", player); ReadLine();
                WriteLine("你仔細看牠的五官，認定牠非常像"+cat+"，但同時，其他四隻也都向你走來，一邊發出你十分熟悉的喵喵聲，儘\n" +
                          "管你以為你一定分辨得出哪個是"+cat+"，但事實是你分不出來。"); ReadLine();
                WriteLine(player + ": 怎麼辦，我要怎麼把{0}帶回家?也許該給牠們一些測試?恩...，cat跟其他的貓不同，牠不排斥我抱、牠\n",cat +
                    "最喜歡跟我玩手手老鼠的遊戲、為了找到牠的時候可以引誘牠我還帶了牠最愛的罐罐。");ReadLine();
                Write("你要?A.抱抱看  B.玩手手老鼠的遊戲 C.罐頭測試。選擇A或B或C:");
                char aorb3 = ReadLine().ToCharArray()[0];
                bool ok2 = aorb3 == 'a' || aorb3 == 'b' || aorb3 == 'A' || aorb3 == 'B' || aorb3 =='C' || aorb3 == 'c';
                while (!ok2)
                {
                    WriteLine("輸入錯誤，請重新輸入: ");
                    aorb3 = ReadLine().ToCharArray()[0];
                    ok2 = aorb3 == 'a' || aorb3 == 'b' || aorb3 == 'A' || aorb3 == 'B' || aorb3 == 'C' || aorb3 == 'c';
                    if (ok2) break;
                }
                switch (aorb3)
                {
                    case 'A':
                    case 'a':
                        ReadLine();
                        WriteLine("你抱起其中一隻貓，兩手環繞著牠，牠很乖，身上也沒有髒污或味道，看起來不像是流浪貓，你騰出一隻手摸\n" +
                                  "摸貓的臉，牠開始呼嚕嚕。牠抱起來沉甸甸的，肉肉的身量和{0}差不多。",cat); ReadLine();
                        WriteLine(player + ": 好舒服啊...呵呵");ReadLine();
                        WriteLine("不知道是不是你摸貓的技巧太高超了，五隻貓被你抱起來後都開始呼嚕嚕，一副快睡著的樣子，於是你像哄小\n" +
                                  "孩一樣輪流抱了每隻貓好一陣子，好消息是—壞消息也是，牠們都很願意讓你抱，抱起來也差不多重。");ReadLine();
                        break;
                    case 'B':
                    case 'b':
                        ReadLine();
                        WriteLine("你脫下風衣，用風衣遮住整隻手臂，只露出幾隻手指，同時手指快速的在風衣底下移來移去，嘴裡配上老鼠移\n" +
                                  "動時悉悉素素的聲音。"); ReadLine();
                        WriteLine("五隻貓的瞳孔同時快速的變大，牠們更一致的把身體往前貼，耳朵後豎成飛機耳，屁股翹的高高的，整個身子\n" +
                                  "和尾巴有規律地左右擺動，幾秒鐘後牠們同時向你藏在風衣後的手衝過來，伸出有尖銳爪子的掌子拍擊這隻「\n" +
                                  "老鼠」。");ReadLine();
                        WriteLine(player + ": 額..");ReadLine();
                        WriteLine(player + ": 額...啊!!"); ReadLine();
                        WriteLine("這次是牠們貓多勢眾，你流血了。"); ReadLine();
                        break;
                    case 'C':
                    case 'c':
                        ReadLine();
                        WriteLine("你從口袋裡拿出罐頭，打開，其中一隻貓迅速的喵喵喵著向你衝過來，一副餓了很久的樣子。"); ReadLine();
                        WriteLine(player + ": 所以...這隻?"); ReadLine();
                        WriteLine("其他的橘貓同時也期待地盯著罐頭看，等到第一隻貓吃了一些走開來，另一隻貓接著補上，你看著他們一隻接\n" +
                                  "著一隻吃完了罐頭。"); ReadLine();
                        WriteLine(player + ": 他們有地位的區分，那麼這些都不是{0}?",cat); ReadLine();
                        break;
                }

                WriteLine("你絕望地低下頭，想著你大概是分不出來了，抬起頭時，周遭的景色開始變化，由你為中心延伸出的同心圓\n" +
                          "又開始成為了跟著光影變化的亮麗線條，此時帶著黎明前的微明，色彩更為清麗，只是掩著一層薄霧，你呆\n" +
                          "呆地望著周遭的變化，突然你聽到細細的嗓音。");ReadLine();
                WriteLine(player + ": ?"); ReadLine();
                WriteLine("貓在跟你說話，等等，貓在跟你說話?"); ReadLine();
                WriteLine("橘貓之一: 跳下去。"); ReadLine();
                WriteLine(player + ": ?"); ReadLine();
                WriteLine("橘貓之一: 你要從這邊跳下去，跳下去才能找到你的貓喔。"); ReadLine();
                WriteLine("說完話，你還來不及做出回應，貓咪們已經排成一排，跟你說話的貓率先跳到水泥台階上，接著輕盈的往下跳，\n" +
                          "其他的貓也跟著咚、咚、咚的跳下去，牠們跳下去前都發出了給自己打氣似的喵的短促聲音。"); ReadLine();
                WriteLine("橘貓之一: 你要從這邊跳下去，跳下去才能找到你的貓喔。"); ReadLine();
                WriteLine("你站在窄窄的台階上，倒數三、二、一，你往下跳。"); ReadLine();
                WriteLine("剛跳下去時你還有意識，逼自己清醒地看著對街的公寓，但是隨著你墜落到了中段，你失去了意識，那一剎那你\n" +
                           "想起剛剛總共爬了七樓。"); ReadLine();
                WriteLine("\tChapter 2 end\n\n");
            }

        }
        public static void Chapter3(string player, string cat)
        {
            { //ch3前面劇情
                WriteLine("\tChapter 3 memory"); ReadLine();
                WriteLine("「你」恢復了意識時，周遭的一切—現在又成了原本正常世界的景色，而天已經亮了，但寬廣的路面現在卻沒\n" +
                          "有任何人—以比例來說變得特別的高大，路邊紅色的消防栓在俯視你，紅綠燈從路面高高拔起，像是參天巨樹，\n" +
                          "而原本看慣了的公寓本身更是像是摩天大廈那麼高，但是你對於眼前的變化同樣沒有太多留心，只是覺得自己\n" +
                          "好像到了未來城市。"); ReadLine();
                WriteLine("你突然想起自己正在找{0}。",cat); ReadLine();
                WriteLine("你往前跑，跑了幾步後你發現自己用四肢著地在奔跑，而你全身的毛髮都隨著周遭的氣流自然而然的運動，你\n" +
                          "可以感覺到風在頸邊掃過，而你流暢的奔跑動作與四周環境交織為一體，此外，你的鬍鬚與尾巴很好地扮演了\n" +
                          "平衡的作用，等等，尾巴!?"); ReadLine();
                WriteLine("你停下，低頭看看自己的身軀，看到了全身漂亮的橘毛，看到了自己可愛的肉掌像小饅頭一樣的並排在身前。"); ReadLine();
                WriteLine(player + ": 咦，我變成貓了嗎?"); ReadLine();
                WriteLine("同樣的你並沒有想太多，也沒有仔細思考這件事和找{0}的關聯。",cat); ReadLine();
                WriteLine("此時，遠方有個高大的人影快速的轉進一條巷子，那個身影看起來非常熟悉，簡直就像是...你自己，在你這\n" +
                          "樣想的同時，你似乎開始把自己當成{0}，而遠方的人影則是你的奴才。",cat); ReadLine();
                WriteLine("{0}: {1}，{1}，不要跑啊", cat, player, player); ReadLine();
                WriteLine("你心中是這麼想的，但聽起來卻像是喵 ! 喵 !! 喵!!!"); ReadLine();
                WriteLine("你跟著跑進了那條巷子，在巷子最遠的那一端你又看到了{0}，但同時在彎進巷子處，有三個杯子靜靜躺\n",player +
                          "在地上，你看看走遠的{0}，卻又忍不住被那些杯子吸引，你走近看，失望的發現裡面並沒有肉，而是裝了\n", player+
                          "水，但是你也剛好很口渴了，很想喝些水..."); ReadLine();
            }

            Program.Water(player);
            {
                WriteLine("此時{0}已經走到巷子的末端，要繞過一個轉角了，你又把注意力集中在{0}身上，開始往前跑，一邊\n",player,player +
                          "喵喵喵喵的叫。終於你在左轉處又看到{0}，你們的距離近了一些，但是此時，你的視線瞄到一旁有個看\n", player +
                          "起來新奇的玩具，長得就像是家裡的貓跳台，你看看走遠的{0}，但實在擋不住玩具的誘惑...",player);ReadLine();
            }
            Program.Hanoi();
            { //ch3後面劇情
                WriteLine("雖然多花了些時間，但你發現{0}並沒有走遠，只是繞過了另一個轉角，往大街上走，不過剛剛玩得有點喘，\n" +
                          "你只能跺著小步往{0}的方向跑過去，在街上，你看到{0}走進一家商店大門。",player,player,player);ReadLine();
                WriteLine("「xx動物醫院」");ReadLine();
                WriteLine("你不喜歡到醫院，醫院總是讓你很緊張，現在也是，裡面散發著一種焦慮與悲傷的味道。隔著玻璃，你看到" +
                          "{0}坐在背靠著外面玻璃的座位區，從他的側臉看起來，他好像很不開心。", player);ReadLine();
                WriteLine("突然，醫院裡的工作人員開了門，指著你說: 貓咪要來打針囉!");ReadLine();
                WriteLine("你發出喵喵喵的抗議聲，表示自己不想打針，但是他們沒有聽你說話，有其他工作人員跑出來圍住你，他們接\n" +
                          "著把你倒過來壓在工作檯上，用力握住你的一隻手，你看到亮晃晃的針筒朝你靠近...");ReadLine();
                WriteLine("\tChapter 3 end\n\n"); ReadLine();
            }
        }
        public static void Chapter4(string player, string cat, char tarotaorb)
        {
            { //ch4前面劇情
                WriteLine("\tChapter 4 choice"); ReadLine();
                WriteLine("你從夢境中醒來，渾身是汗，現在是早上六點。"); ReadLine();
                WriteLine("我剛剛做夢了?好像是有關{0}的...", cat); ReadLine();
                WriteLine("{0}生病了，牠已經在獸醫院待了兩個星期了，你每天下課後第一件事就是去動物醫院看{0}。牠現在住在醫院的小\n", cat, cat +
                          "籠子裡，沒有太多的活動空間，{ 0} 每次看到你都會喵喵喵喵的叫，牠的前腳上綁著點滴管，繃帶上有個地方滲出\n",cat+
                          "暗紅色的圓點。 第一天cat住進醫院時，你看著牠打針，牠看起來很痛、很不舒服。");ReadLine();
                WriteLine(cat + "生病了，牠已經在獸醫院待了兩個星期了，你每天下課後第一件事就是去動物醫院看" + cat + "。牠現在住\n" +
                          "在醫院的小籠子裡，沒有太多的活動空間，" + cat + "每次看到你都會喵喵喵喵的叫，牠的前腳上綁著點滴管，繃帶\n" +
                          "上有個地方滲出暗紅色的圓點。 第一天" + cat + "住進醫院時，你看著牠打針，\n牠看起來很痛、很不舒服。"); ReadLine();
                WriteLine("是突變的病毒，雖然" + cat + "是十歲的老貓，但從健康檢查知道" + cat + "一直很健康。突然間牠就生病了。"); ReadLine();
                WriteLine("動物的醫療一直很困難，一開始你跑了好幾家醫院都找不到原因，到了現在這家，醫生才確定的說找到病因，這種新型\n" +
                            "疾病的治療藥物很貴，打一劑要價上千，加上每天的住院費、抽血檢查等費用，寵物\n沒有健保，你的存款已經所剩無幾了。"); ReadLine();
                WriteLine("明天就要決定是不是要再購買之後的藥，要繼續嗎?"); ReadLine();
                WriteLine("即使要和家人朋友開口借錢?"); ReadLine();
                WriteLine("即使" + cat + "要受這麼多苦，卻不知道會不會好?"); ReadLine();
                WriteLine("你和" + cat + "都要非常堅強才有可能撐下去。"); ReadLine();
                WriteLine("要繼續救貓嗎?是/否"); ReadLine();
            }
            
            {
                Write("你要? A救. B.不救 ");
                char aorb3 = ReadLine().ToCharArray()[0];
                bool ok1 = aorb3 == 'a' || aorb3 == 'b' || aorb3 == 'A' || aorb3 == 'B';
                while (!ok1)
                {
                    WriteLine("輸入錯誤，請重新輸入: ");
                    aorb3 = ReadLine().ToCharArray()[0];
                    ok1 = aorb3 == 'a' || aorb3 == 'b' || aorb3 == 'A' || aorb3 == 'B';
                    if (ok1) break;
                }
                switch (aorb3)
                {

                    case 'A':
                    case 'a':
                        WriteLine("\n你打算不管付出多少都要救"+cat); ReadLine();                            
                        break;
                    case 'B':
                    case 'b':
                        WriteLine(cat+"死了，你找了專門的公司幫你處理了"+cat+"的身後事，你做出了這個選擇，並不是不愛"+cat+"，只是來自經濟\n" +
                                    "上的壓力、看"+cat+"每天打針，打到牠小小的腳上再也沒地方可以注射，皮膚發爛、自己每天不斷擔心、上課上班，\n"+
                                    "這些都是你的生活，你不可能完全拋下不管。再怎麼愛牠，你想自己都無法承受更多了。"); ReadLine();
                        WriteLine("\n\t不知道哪一天起 不知道哪一天止\n" +
                                    "\t你一直都藏在 我心底\n" +
                                    "\t時光停在你眼裡\n" +
                                    "\t害怕得不敢聲息\n" +
                                    "\t寶貝 by 莫文蔚"); ReadLine();
                        break;
                }
            }
            
            { //ch4後面劇情
                //ch4最後的猜數字   tarotaorb使用CH0的章節

                int guess;
                int smallguess = 0;
                int bigguess = 21;
                int maxn = 0;
                ReadLine();
                WriteLine("抉擇高塔");
                WriteLine("遊戲規則是，系統已經預先設定了謎底，您必須在0到21之間選擇數字，目標是避開謎底。");
                WriteLine("當您輸入的數字比謎底大或小，系統將會告訴您接下來你可以猜測的範圍。 ");
                WriteLine("最後，如果能將範圍限制到最小而避開謎底，就算是贏得遊戲。");
                Write("猜一個數字: ");
                guess = int.Parse(ReadLine());
                switch (tarotaorb)
                {
                    case 'A':
                    case 'a':
                        maxn++;
                        while (guess != 16 && maxn < 5)
                        {
                            while ((guess > 21 || guess < 0) && maxn < 5)
                            {
                                Write("輸入數字超出範圍，請重新輸入: ");
                                guess = int.Parse(ReadLine());
                            }
                            while (guess < 16 && guess >= 0 && maxn < 5)
                            {
                                smallguess = guess;
                                Write("\n{0}比謎底小，接下來請在{1}和{2}間選擇一個數字: ", smallguess, smallguess, bigguess);
                                guess = int.Parse(ReadLine());
                                maxn++;
                                if (maxn > 5) break;
                            }
                            while (guess > 16 && guess <= 21 && maxn < 5)
                            {
                                bigguess = guess;
                                Write("\n{0}比謎底大，接下來請在{1}和{2}間選擇一個數字: ", bigguess, smallguess, bigguess);
                                guess = int.Parse(ReadLine());
                                maxn++;
                            }
                        }
                        if (guess == 16)
                        {
                            ReadLine();
                            WriteLine("您作出了正確的抉擇。");
                            ReadLine();
                            WriteLine(cat+"剛上完廁所，現在正興奮地在家裡跑來跑去。"); ReadLine();
                            WriteLine(player + ":「" + cat + "，你的大便好臭」"); ReadLine();
                            WriteLine("嘴上這麼說，但是你的嘴角微微上翹，洩漏了你的心情。"); ReadLine();
                            WriteLine("你慶幸當初決定撐下去，雖然用光了所有存款，還欠了家人和朋友一堆錢，這段時間\n" +
                                      "過得一糰糟，但是看到一切回到原本的樣子，你覺得自己很幸運，一切都很值得。"); ReadLine();

                            WriteLine("" +
                                "\t便便和尿尿給你" +
                                "\t零食和玩具給我\n" +
                                "\t我現在不想理你\n" +
                                "\t除非你開個罐頭\n\n" +
                                "\t貓咪共和國 by 韋禮安"); ReadLine();
                        }
                        else
                        {
                            ReadLine();
                            WriteLine("您的猜測次數超過上限。");
                            ReadLine();
                            WriteLine(cat + "死了，" + cat + "堅持不到到最後。"); ReadLine();

                            WriteLine(player + ": 我們都已經盡力了，接下來的路是我自己的旅程。但是你給了我那麼多的回憶，我想我不會感到孤單。"); ReadLine();
                            WriteLine("你想起" + cat + "剛到家裡那時，" + cat + "作息還沒跟你一致，每天晚上都興奮地到處亂跑，整天一直叫，\n" +
                                      "讓你完全睡不好覺，你還在網路上查詢要怎麼教牠，像是如果牠開始亂抓沙發就用小的澆花器噴牠水，但後來\n" +
                                      "因為" + cat + "的表情太無辜讓你放棄這個方法，放著牠任性，牠那時還那麼小。"); ReadLine();
                            WriteLine("你想起高中時，跟家人大吵的夜晚，你躲在棉被裡哭了起來，" + cat + "難得安靜，坐在你旁邊，慢慢對你眨眼，\n" +
                                      "好似理解你的心情，有時牠會舔舔你的臉，網路上說貓舔人是想要鹽分，你想，牠也知道眼淚是鹹的呀。"); ReadLine();
                            WriteLine("你想起每個冬天，你去睡覺，牠就會在被子旁邊走來走去，示意你掀開被子讓牠也進去，然後牠會在你的臂彎中把頭\n" +
                                       "和小小的手掌靠在你的手臂上，牠很溫暖，但十分鐘後你會開始手麻，然後緩緩睡去。"); ReadLine();
                            WriteLine("你想起牠有泌尿道疾病，每次復發你都要花好幾萬塊，但你還是甘之如飴的把這當作賺錢的動力，只是每次回家看到又\n" +
                                       "沾了血尿的棉被要換，地板要擦，" + cat + "看起來好不舒服，你就無助地掉下眼淚，但又一邊提醒自己要堅強，貓也\n" +
                                       "是會察覺鏟屎官的情緒的..."); ReadLine();


                                        WriteLine("" +
                                                 "\t輕撫著你的頭 睡吧" +
                                                 "\t我在你夢裡\n" +
                                                 "\t不管醒在哪裡\n" +
                                                 "\t寶貝 我記得你\n\n" +
                                                 "\t寶貝 by 莫文蔚"); ReadLine();
                        }
                        break;
                    case 'B':
                    case 'b':

                        while (guess != 13)
                        {
                            while (guess > 21 || guess < 0)
                            {
                                Write("輸入數字超出範圍，請重新輸入: ");
                                guess = int.Parse(ReadLine());
                            }
                            while (guess < 13 && guess >= 0)
                            {
                                smallguess = guess;
                                Write("\n{0}比謎底小，接下來請在{1}和{2}間選擇一個數字: ", smallguess, smallguess, bigguess);
                                guess = int.Parse(ReadLine());
                                if (smallguess == 12 && guess == 14)
                                {
                                    bigguess = guess;
                                }
                                if (smallguess == 12 && bigguess == 14) break;
                            }
                            while (guess > 13 && guess <= 21)
                            {
                                bigguess = guess;
                                Write("\n{0}比謎底大，接下來請在{1}和{2}間選擇一個數字: ", bigguess, smallguess, bigguess);
                                guess = int.Parse(ReadLine());
                                if (bigguess == 14 && guess == 12)
                                {
                                    smallguess = guess;
                                }
                                if (smallguess == 12 && bigguess == 14) break;
                            }
                            if (smallguess == 12 && bigguess == 14) break;
                        }
                        if (guess == 13)
                        {
                            ReadLine();
                            WriteLine("您猜中謎底。");
                            ReadLine();
                            WriteLine("{0}死了。\n\n", cat);
                        }
                        else
                        {
                            ReadLine();
                            WriteLine("您贏了。");
                            ReadLine();
                            WriteLine("{0}活下來了。\n\n", cat);
                        }
                        break;
                }
            }              
                    }
        //========CH0 game=============        
        public static void Maze()
        {
            string input;
            char[,] map = new char[10, 10];
            int[] MazePlayer = new int[2] { 1, 0 };
            Display(MazePlayer);
            while (true)
            {
                input = ReadKey().Key.ToString();

                if (input == "RightArrow" && map[MazePlayer[0], MazePlayer[1] + 1] != '■') MazePlayer[1]++;
                if (input == "LeftArrow" && map[MazePlayer[0], MazePlayer[1] - 1] != '■') MazePlayer[1]--;
                if (input == "UpArrow" && map[MazePlayer[0] - 1, MazePlayer[1]] != '■') MazePlayer[0]--;
                if (input == "DownArrow" && map[MazePlayer[0] + 1, MazePlayer[1]] != '■') MazePlayer[0]++;

                map = Display(MazePlayer);
                if (MazePlayer[0] == 8 && MazePlayer[1] == 9)
                {
                    WriteLine();
                    Write("Clear!!");
                    break;
                }
            }
        }
        public static char[,] Display(int[] MazePlayer)
        {
            char[,] map = new char[10, 10]{
                { '■','■','■','■','■','■','■','■','■','■'},
                { '　','　','　','■','　','　','　','■','　','■'},
                { '■','　','　','■','　','■','　','■','　','■'},
                { '■','　','■','■','■','■','　','　','　','■'},
                { '■','　','　','　','　','■','　','■','　','■'},
                { '■','■','■','■','　','■','　','■','　','■'},
                { '■','　','　','　','　','■','　','■','　','■'},
                { '■','　','■','■','■','■','　','■','　','■'},
                { '■','　','　','　','　','　','　','■','　','★'},
                { '■','■','■','■','■','■','■','■','■','■'}
            };

            map[MazePlayer[0], MazePlayer[1]] = '◇';

            WriteLine("使用方向鍵控制主人公(↑,↓,→,←)");
            WriteLine();
            for (int j = 0; j < map.GetLength(0); j++)
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    Write(map[j, i]);
                }
                WriteLine();
            }
            SetCursorPosition(0, CursorTop - 12);       //用這取代畫面Clear 減少閃屏
            return map;
        }
        //========CH1 game=============
        public static void A1B2(string player, string cat)
        {
            Random ram = new Random();                          //設置隨機數
            WriteLine("【您將進入遊戲 : 猜數字，猜對解鎖手機吧】\n打開手機的解鎖畫面，需要輸入四個「不重複」的數字，輸入後手機會提示幾個數字和位置正確(記為A)幾個數字正確位置錯誤(記為B)，輸入的數字不應該重複(>_<)"); ReadLine();
            WriteLine("請輸入數字：");
            int type = 4;
            int[] list = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };  //設置數字的list
            string answer = "";                                 //宣告答案為空字串

            string[] list2 = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            for (int i = 0; i < type; i++)                  //設置臨時list2用以剔除重複的數字
            {
                int ramNum = ram.Next(0, 10 - i - 1);
                answer = answer + list2[ramNum];                             //置入不重複的答案
                list2 = list2.Where(val => val != list2[ramNum]).ToArray();  //.NET此版本沒有remove 參考 https://dotblogs.com.tw/marcus116/2011/07/10/31423 
            }

            //開始猜
            int count = 0;                              //設置猜的次數器
            bool bingo = false;                         //
            while (bingo != true)                       //猜中就結束                      
            {
                if (count > 9)
                {
                    WriteLine("糟糕，輸入錯誤太多次，手機被鎖起來了"); ReadLine();
                    break;
                }
                count = count + 1;                      //每執行一次 猜的次數器+1
                string userGuess = ReadLine();  //取得用戶輸入的數字
                if (userGuess == answer)                 //如果輸入的數字正確則跳出
                {
                    bingo = true;
                    WriteLine("你一邊看著網路小說時，手機突然跳出通知，原來是雲端相簿自動幫你匹配的「十年前的今天」照片，那時還\n" +
                        "是國中生的你，拍下了被小時候的{0}抓爛的沙發和窗簾照。", cat); ReadLine();
                    WriteLine("{0}:{1}後來不知不覺就變得很乖了...時間過得好快喔... ", player, cat);
                    break;
                }
                int A = 0, B = 0;                       //宣告幾A幾B，預設為0

                char[] AB1, AB2;                         //宣告幾AB1 AB2，作為字串比叫的用途
                AB1 = userGuess.ToCharArray();
                AB2 = answer.ToCharArray();
                for (int i = 0; i < type; i++)          //比較兩個Array，如果在相同位置相同的話等於A 記一次
                {
                    if (AB1[i] == AB2[i])
                    {
                        A = A + 1;
                        AB1[i] = 'x';                   //將比對過的元素替代調以避免重複
                    }
                }
                for (int i = 0; i < type; i++)          //比較兩個Array，如果在不位置相同的話等於B 記一次
                {
                    for (int j = 0; j < type; j++)
                    {
                        if (AB1[j] == AB2[i])
                        {
                            B = B + 1;
                            AB1[i] = 'x';
                        }
                    }
                }
                WriteLine("手機顯示：{0}A{1}B", A, B);    //輸出幾A幾B
            }
        }
        //========CH2 game=============
        public static void Minesweeper()
        {
            int msCur = 0;
            const int XMAX = 9;
            const int YMAX = 9;
            const int nMine = 10;
            bool[,] isOpened = new bool[XMAX + 2, YMAX + 2];
            bool[,] isMine = new bool[XMAX + 2, YMAX + 2];
            int[,] neighborMine = new int[XMAX + 2, YMAX + 2];


            string input;
            int x, y;

            InitializeMap(nMine, isOpened, isMine, neighborMine, XMAX, YMAX);
            DispayMap(isOpened, isMine, neighborMine, XMAX, YMAX);

            while (true)
            {
                input = ReadLine();
                if (input == "1")
                {
                    msCur = msCur + 1;
                    InitializeMap(nMine, isOpened, isMine, neighborMine, XMAX, YMAX);
                    DispayMap(isOpened, isMine, neighborMine, XMAX, YMAX);
                    continue;
                }
                else if (input == "2") break;
                else
                {
                    if (input[0] >= 'A' && input[0] <= 'I') x = input[0] - 'A' + 1;
                    else
                    {
                        DispayMap(isOpened, isMine, neighborMine, XMAX, YMAX);
                        continue;
                    }

                    if (input[1] >= '1' && input[1] <= '9') y = int.Parse(input[1].ToString());
                    else
                    {
                        DispayMap(isOpened, isMine, neighborMine, XMAX, YMAX);
                        continue;
                    }

                    openCell(x, y, XMAX, YMAX, isOpened, isMine, neighborMine);
                    DispayMap(isOpened, isMine, neighborMine, XMAX, YMAX);
                    if (isSuccess(XMAX, YMAX, isOpened, isMine))
                    {
                        WriteLine("你成功的避開了所有蟲屍。"); ReadLine();
                        WriteLine("你想起有幾次從床上醒來，發現床邊的地板上掉落著翻肚的蟑螂屍體，上網查才知道貓咪會把獵物當成禮物送\n" +
                            "給照顧者，你總是有些竊喜的覺得" + cat + "還是很愛你的。"); ReadLine();
                        WriteLine("不過牠比較大了後，對蟲子之類的就比較不感興趣了呢。"); ReadLine();
                        break;
                    }
                    if (isMine[x, y])
                    {
                        WriteLine("你踩到了，鞋底發出叭機的聲音...");
                        break;
                    }
                }
            }

        }
        public static void InitializeMap(int nMine, bool[,] isOpened, bool[,] isMine, int[,] neighborMine, int x, int y)
        {
            int i, j;

            for (i = 0; i < x + 2; i++)
            {
                for (j = 0; j < y + 2; j++)
                {
                    isOpened[i, j] = false;
                    isMine[i, j] = false;
                    neighborMine[i, j] = 0;
                }
            }

            for (int k = 0; k < nMine; k++)
            {
                do
                {
                    i = (int)(new Random().Next() % x + 1);
                    j = (int)(new Random().Next() % y + 1);
                } while (isMine[i, j]);

                isMine[i, j] = true;

                neighborMine[i - 1, j - 1] += 1;
                neighborMine[i, j - 1] += 1;
                neighborMine[i + 1, j - 1] += 1;
                neighborMine[i - 1, j] += 1;
                neighborMine[i + 1, j] += 1;
                neighborMine[i - 1, j + 1] += 1;
                neighborMine[i, j + 1] += 1;
                neighborMine[i + 1, j + 1] += 1;
            }
        }
        public static void DispayMap(bool[,] isOpened, bool[,] isMine, int[,] neighborMine, int x, int y)
        {
            SetCursorPosition(0, CursorTop - 21);
            WriteLine("===============Minesweeper===============\nWhere would you like to open?(ex:A6)");
            Write("\n\n        Ａ Ｂ Ｃ Ｄ Ｅ Ｆ Ｇ Ｈ Ｉ\n");

            for (int j = 1; j <= y; j++)
            {
                Write("      ");
                Write(j);
                Write(" ");

                for (int i = 1; i <= x; i++)
                {
                    if (!isOpened[i, j]) Write("■");
                    else if (isMine[i, j]) Write("＊");
                    else if (neighborMine[i, j] == 0) Write("．");
                    else Write(" " + neighborMine[i, j]);
                    Write(" ");
                }
                WriteLine();
            }

            WriteLine("\n\nOther options:\n1.重新走\n2.算了不管了直接走過去\n=========================================");
        }
        public static void openCell(int x, int y, int XMAX, int YMAX, bool[,] isOpened, bool[,] isMine, int[,] neighborMine)
        {
            if (x < 1 || x > XMAX || y < 1 || y > YMAX) return;
            if (isOpened[x, y]) return;

            isOpened[x, y] = true;
            if (!isMine[x, y] && neighborMine[x, y] == 0)
            {
                openCell(x - 1, y - 1, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x, y - 1, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x + 1, y - 1, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x - 1, y, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x + 1, y, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x - 1, y + 1, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x, y + 1, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x + 1, y + 1, XMAX, YMAX, isOpened, isMine, neighborMine);
            }
        }
        public static bool isSuccess(int XMAX, int YMAX, bool[,] isOpend, bool[,] isMine)
        {
            for (int x = 1; x <= XMAX; ++x)
            {
                for (int y = 1; y <= YMAX; ++y)
                {
                    if (!isMine[x, y] && !isOpend[x, y])
                        return false;
                }
            }
            return true;

        }
        //========CH3-1 game===========
        public static void Water(string player)
        {
            int[] cupWater = { 0, 0, 0 }; /*初始水量*/
            int[] cupFull = { 7, 10, 5 };/*杯子容量(7/10/5是經典題目)*/
            int answer = 6;/*答案要求水量*/
            bool right = false;
            WriteLine("【您即將挑戰遊戲 : 分水解謎】\n【杯子太高了，要加多一點水才喝得到呢!加的太多了水又會碰到臉，加油!(>_<)】"); ReadLine();
            WriteLine("\t輸入說明：");
            WriteLine("\t[1]、[2]、[3]：杯子編號左至右");
            WriteLine("\tex:2：將第2個水杯裝滿或倒光（只需輸入數字）");
            WriteLine("\tex:12：將左邊的水杯倒向右邊（只需輸入數字）");
            WriteLine("\tex:Z、14：輸入非指定輸入為解謎失敗");
            WriteLine("--------------------------------------");
            WriteLine("\t請在任一杯子裝入6的水量");
            WriteLine("\t杯[1]\t杯[2]\t杯[3]");
            WriteLine("-----------當前水量/水杯容量----------\n\n\n");

            while (right == false)
            {
                SetCursorPosition(0, CursorTop - 3);
                WriteLine("\t\t\t\n\t\t\t\n\t\t\t\n");
                SetCursorPosition(0, CursorTop - 4);
                for (int i = 0; i < 3; i++)
                {
                    Write("\t{0}/{1}", cupWater[i], cupFull[i]);
                }
                WriteLine("\n\t\t\t  \tnext");
                string input = ReadLine();
                string inpMatch = "[123]{1,2}";
                bool inputIsMatch = Regex.IsMatch(input, inpMatch);
                if (inputIsMatch == false)
                {
                    Write("失敗了"); ReadLine();
                    break;
                }

                if (input.Length > 1)
                {

                    int A = Convert.ToInt32(input.Substring(0, 1)) - 1;
                    int B = Convert.ToInt32(input.Substring(1, 1)) - 1;
                    int i, j;
                    if (cupWater[A] + cupWater[B] <= cupFull[B])
                    {
                        cupWater[B] = cupWater[A] + cupWater[B];
                        cupWater[A] = 0;
                    }
                    else if (cupWater[A] + cupWater[B] > cupFull[B])/*7/7 5/10*/
                    {
                        i = cupWater[A] - (cupFull[B] - cupWater[B]);
                        cupWater[B] = cupWater[A] + cupWater[B] - i;
                        cupWater[A] = i;
                    }
                }
                else
                {
                    if (cupWater[Convert.ToInt32(input) - 1] > 0)
                    {/*有水倒掉*/
                        cupWater[Convert.ToInt32(input) - 1] = 0;
                    }
                    else
                    {/*沒水裝滿*/
                        cupWater[Convert.ToInt32(input) - 1] = cupFull[Convert.ToInt32(input) - 1];
                    }
                }

                for (int j = 0; j < 3; j++)
                {
                    if (cupWater[j] == answer)
                    {
                        WriteLine("你成功地喝到了水，覺得今天的喝水量很足夠了。"); ReadLine();
                        WriteLine("喝完後，你突然想起小時候因為不愛喝水，所以身體不好。" + player + "總是會做一種吃起來很Q彈的食物給你吃，\n" +
                                   player + "稱呼它為「水凍」，好像還有什麼「吉利丁」，" + player + "如果發現你把罐罐裡多的水都舔到碗外就會生氣\n" +
                                   "地看著你，你常常故意忽略" + player + "的怒氣。"); ReadLine();
                        WriteLine("「反正我那麼可愛，" + player + "等一下就會忘記生氣了」。"); ReadLine();

                        right = true;
                    }
                }
            }
        }
        //========CH3-2 game===========
        public static void Hanoi()
        {
            WriteLine("【您將進入遊戲: 貓跳台】");
            WriteLine("這邊有三根柱子，上面有依大小放置的貓跳版");
            WriteLine("請試著一次移動一個盤子，將貓跳版全部移到第三柱");
            WriteLine("請注意大貓跳版不能放在小貓跳版之上");
            WriteLine("[1]、[2]、[3]：柱子編號左至右");
            WriteLine("輸入說明：");
            WriteLine("ex:11：將左邊柱子最上面的貓跳版移到右邊最上面（請輸入兩位純數字）\n");

            WriteLine("-----------------------------------------");
            WriteLine("任務：請將柱[1]的貓跳版全部移到柱[3]");
            WriteLine("　　柱[1]\t　　柱[2]\t　　柱[3]");
            WriteLine("-----------------當前情況---------------");

            WriteLine("　　｜　　\t　　｜　　\t　　｜　　");
            WriteLine("　　｜　　\t　　｜　　\t　　｜　　");
            WriteLine("　　｜　　\t　　｜　　\t　　｜　　");
            WriteLine("　　｜　　\t　　｜　　\t　　｜　　");
            WriteLine("　　■　　\t　 ■■　 \t　　｜　　");
            WriteLine(" ■■■■ \t　■■■　\t■■■■■\n\t\t\t\tnext");

            string[] arr = { "0000149", "0000239", "0000059" };//設置9為底，運算不影響,0為無
            string _1, _2, _3;

            //補0
            arr[0] = arr[0].PadLeft(7, '0');
            arr[1] = arr[1].PadLeft(7, '0');
            arr[2] = arr[2].PadLeft(7, '0');

            //移除0
            _1 = Convert.ToString(Convert.ToInt32(arr[0]));
            _2 = Convert.ToString(Convert.ToInt32(arr[1]));
            _3 = Convert.ToString(Convert.ToInt32(arr[2]));


            int cur = 0;
            int count = 0;
            string answer = "0123459";
            int x = Convert.ToInt32(answer);
            bool right = false;
            while (right == false)
            {
                count = count + 1;
                string input = ReadLine();

                /*
                _A = Convert.ToString(Convert.ToInt32(A));
                _B = Convert.ToString(Convert.ToInt32(B));
                _C = Convert.ToString(Convert.ToInt32(C));
                */
                int inX = Convert.ToInt32(input.Substring(0, 1)) - 1;//兩個字串 分別是柱的編號
                int inY = Convert.ToInt32(input.Substring(1, 1)) - 1;
                int _X = Convert.ToInt32(arr[inX]);
                int _Y = Convert.ToInt32(arr[inY]);//兩輸入的柱目前情況

                int _1X = Convert.ToInt32(Convert.ToString(_X).Substring(0, 1));
                int _1Y = Convert.ToInt32(Convert.ToString(_Y).Substring(0, 1));//兩柱的第一個盤子數字

                if ((_1X > _1Y) || (_1X == _1Y))
                {
                    SetCursorPosition(0, CursorTop - 2);
                    WriteLine("\t\t\t  \tnext\n\t\t\t");
                    SetCursorPosition(0, CursorTop - 1);
                    /*cur = cur + 5;
                    WriteLine("輸入錯誤 重新輸入  \n格式為2位數字不添加其他符號");*/
                }
                else //將替換數字
                {
                    _X = Convert.ToInt32(Convert.ToString(_X).Substring(1, Convert.ToString(_X).Length - 1));
                    _Y = Convert.ToInt32(Convert.ToString(_1X) + Convert.ToString(_Y));
                    arr[inX] = Convert.ToString(_X);
                    arr[inY] = Convert.ToString(_Y);
                    arr[inX] = arr[inX].PadLeft(7, '0');
                    arr[inY] = arr[inY].PadLeft(7, '0');

                    string[] arrbar = {
                        "　　｜　　",
                        "　　■　　",
                        "　 ■■　 ",
                        "　■■■　",
                        " ■■■■ ",
                        "■■■■■" };
                    SetCursorPosition(0, CursorTop - 8 - cur);
                    cur = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Write(arrbar[Convert.ToInt16(arr[j].Substring(i, 1))] + "\t");
                        }
                        Write("\n");
                    }
                    WriteLine("\t\t\t  \tnext\n\t\t\t");
                    SetCursorPosition(0, CursorTop - 1);
                    if (arr[2] == answer)
                    {
                        WriteLine("成功將貓跳台組裝好了");
                        right = true;
                    }
                }

            }
            if (count > 15)
            {
                WriteLine("雖然成功將貓跳台組裝好了，玩的時候不小心摔下來了，你有點灰頭土臉。"); ReadLine();
            }
            else
            {
                WriteLine("你在跳台上興奮的跳上跳下，還順便用麻繩磨了自己漂亮的爪爪，結束後你覺得內心有股平靜感，壓力都消\n" +
                    "失了。"); ReadLine();
                WriteLine("突然你想起有時候" + player + "會變得很忙，一整天都不在家，回家時看起來也很累，連跟你玩的力氣都沒有。\n" +
                    "有時他又會不睡覺，一直在書桌前坐很久，聽" + player + "說他不是在「上課」、就是「打工」，這樣他才能有錢\n" +
                    "幫你買好吃的和好玩的。"); ReadLine();
                WriteLine("看到他很累的樣子，你也不知道怎麼辦，不過不管你在做什麼，" + player + "好像都覺得你很可愛，他只要靠近\n" +
                    "你、弄亂你身上的毛、湊得很近猛聞你的味道，他就會看起來很開心。你覺得" + player + "真的很呆。對了，你想，\n" +
                    "下次可不可以不要抱那麼緊?"); ReadLine();
            }

        }
    }
}
