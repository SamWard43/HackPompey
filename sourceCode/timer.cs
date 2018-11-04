using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
  public System.Windows.Forms.Timer timer1;
  public int counter = 60;
  public void tick1()
  {
    timer1 = new System.Windows.Forms.Timer(object sender, EventArgs e);
    timer1.Tick += new EventHandler(timer1_Tick);
    timer1.Interval = 1000; // one second
    timer1.Start();
    lblCountDown.Text = counter.ToString();
  }
  private void timer1_Tick(object sender, EventArgs e)
  {
    counter --;
    if (counter == 0)
      timer1.Stop();
    lblCountDown.Text = counter.ToString();
  }
}
