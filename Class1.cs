using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ShadowRoundedPanel : Panel
{
    // --- Properties for Customization ---
    public int CornerRadius { get; set; } = 10;
    public Color ShadowColor { get; set; } = Color.Gray;
    public int ShadowDepth { get; set; } = 5;
    public bool ShowShadow { get; set; } = true;

    // Call Invalidate() when properties change to force a repaint
    // (You would add Set/Get for these properties for a complete solution)

    public ShadowRoundedPanel()
    {
        this.DoubleBuffered = true; // Reduces flickering
    }

    // --- Overriding OnPaint ---
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);

        // 1. Draw Shadow (Simplified)
        if (ShowShadow)
        {
            using (var shadowPath = GetRoundedRectanglePath(
                bounds.X + ShadowDepth,
                bounds.Y + ShadowDepth,
                bounds.Width - ShadowDepth * 2,
                bounds.Height - ShadowDepth * 2,
                CornerRadius))
            {
                // A simplified shadow is a semi-transparent fill shifted slightly
                using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, ShadowColor)))
                {
                    g.FillPath(shadowBrush, shadowPath);
                }
            }
        }

        // 2. Draw the main Rounded Panel
        using (var panelPath = GetRoundedRectanglePath(
            bounds.X,
            bounds.Y,
            bounds.Width - 1,
            bounds.Height - 1,
            CornerRadius))
        {
            // Fill the panel background
            using (SolidBrush bgBrush = new SolidBrush(this.BackColor))
            {
                g.FillPath(bgBrush, panelPath);
            }

            // Optionally, draw a border
            // using (Pen borderPen = new Pen(this.ForeColor, 1))
            // {
            //     g.DrawPath(borderPen, panelPath);
            // }
        }
    }

    // --- Helper Method for Rounded Rectangle Path ---
    private GraphicsPath GetRoundedRectanglePath(int x, int y, int width, int height, int radius)
    {
        GraphicsPath path = new GraphicsPath();

        // Ensure radius is not too large
        radius = System.Math.Min(radius, System.Math.Min(width, height) / 2);

        // Top-left corner
        path.AddArc(x, y, radius * 2, radius * 2, 180, 90);
        // Top-right corner
        path.AddArc(x + width - radius * 2, y, radius * 2, radius * 2, 270, 90);
        // Bottom-right corner
        path.AddArc(x + width - radius * 2, y + height - radius * 2, radius * 2, radius * 2, 0, 90);
        // Bottom-left corner
        path.AddArc(x, y + height - radius * 2, radius * 2, radius * 2, 90, 90);

        path.CloseFigure();
        return path;
    }
}