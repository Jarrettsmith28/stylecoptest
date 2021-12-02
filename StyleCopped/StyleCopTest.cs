namespace StyleCopped
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  /// <summary>
  /// stylecop example.
  /// </summary>
  public class StyleCopTest
  {
    private readonly string horse2;
    private int number;

    /// <summary>
    /// Initializes a new instance of the <see cref="StyleCopTest"/> class.
    /// </summary>
    public StyleCopTest()
    {
      this.horse2 = "black beauty";
    }

    /// <summary>
    /// Finalizes an instance of the <see cref="StyleCopTest"/> class.
    /// </summary>
    ~StyleCopTest()
    {
      Console.WriteLine("i am being destroyed");
    }

    /// <summary>
    /// Gets or sets Dad constructor.
    /// </summary>
    public string? Dad { get; set; }

    /// <summary>
    /// Gets or sets Mom constructor.
    /// </summary>
    private string? Mom { get; set; }

/// <summary>
/// Welcome method.
/// </summary>
/// <param name="twelve">twelve.</param>
/// <returns>int.</returns>
    public static int Welcome(int twelve)
    {
      return twelve;
    }

    /// <summary>
    /// Yips method.
    /// </summary>
    internal static void Yips()
    {
      Console.WriteLine("yip");
    }

    private static string Orange()
    {
      return "orange";
    }

    private void Method1()
    {
      Console.WriteLine("messymessage");
    }

    /// <summary>
    ///  stylecops2 class.
    /// </summary>
    internal class Stylecops2
    {
      /// <summary>
      /// Gets or sets Horses.
      /// </summary>
      public decimal Horses { get; set; }
    }
  }
}
