Point pClient;
private void panel1_MouseDown(object sender, MouseEventArgs e)
{
  if (e.Button == MouseButtons.Left)
  {
    pClient = e.Location;
  }
}

private void panel1_MouseMove(object sender, MouseEventArgs e)
{
  if (e.Button == MouseButtons.Left)
  {
    this.Left += e.X - pClient.X;
    this.Top += e.Y - pClient.Y;
  }
}
