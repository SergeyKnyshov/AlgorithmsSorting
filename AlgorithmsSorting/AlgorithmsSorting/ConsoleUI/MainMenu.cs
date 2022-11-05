
namespace AlgorithmsSorting.ConsoleUI
{
    public class MainMenu
    {
        public static MenuCategory mainMenu = new MenuCategory("Главное меню", new Menu[]
            {
                new MenuApplicationTest("Тестовый вывод",TextSortingActions.Print),

                new MenuCategory("Алгоритмы внутренней сортировки",new Menu[]
                {
                    new MenuApplicationTest("Тестовый вывод",TextSortingActions.Print),
                    new ReturnMenu("Вернуться назад")
                }),
                new ReturnMenu("Выход")
            });
    }
}
