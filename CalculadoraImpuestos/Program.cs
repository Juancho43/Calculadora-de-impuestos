using CalculadoraImpuestos.Model;
using CalculadoraImpuestos.Static;


AppStatic.InstanciarTodo();

List<Order> orders = AppStatic.orders;
Console.WriteLine("\nLista de Órdenes:");
foreach (Order order in orders)
{
    Console.WriteLine(order);
    Console.WriteLine("--------------------"); 
}
