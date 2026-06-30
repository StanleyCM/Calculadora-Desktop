using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Calculadora.WinForms;

public sealed class CircularButton : Button
{
    private bool _mouseOver;
    private bool _mouseDown;

    public CircularButton()
    {
        SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw,
            true);

        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        e.Graphics.Clear(Parent?.BackColor ?? SystemColors.Control);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Color buttonColor = BackColor;
        if (_mouseDown)
        {
            buttonColor = ControlPaint.Dark(buttonColor);
        }
        else if (_mouseOver)
        {
            buttonColor = ControlPaint.Light(buttonColor);
        }

        const int renderScale = 8;
        int renderWidth = Math.Max(1, Width * renderScale);
        int renderHeight = Math.Max(1, Height * renderScale);
        Color backgroundColor = Parent?.BackColor ?? SystemColors.Control;

        using Bitmap renderedCircle = new(
            renderWidth,
            renderHeight,
            PixelFormat.Format32bppPArgb);

        using (Graphics circleGraphics = Graphics.FromImage(renderedCircle))
        {
            circleGraphics.Clear(backgroundColor);
            circleGraphics.SmoothingMode = SmoothingMode.HighQuality;
            circleGraphics.CompositingQuality = CompositingQuality.GammaCorrected;
            circleGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            using SolidBrush brush = new(buttonColor);
            circleGraphics.FillEllipse(
                brush,
                renderScale,
                renderScale,
                renderWidth - (renderScale * 2),
                renderHeight - (renderScale * 2));
        }

        e.Graphics.CompositingMode = CompositingMode.SourceCopy;
        e.Graphics.CompositingQuality = CompositingQuality.GammaCorrected;
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        using (ImageAttributes imageAttributes = new())
        {
            imageAttributes.SetWrapMode(WrapMode.TileFlipXY);
            e.Graphics.DrawImage(
                renderedCircle,
                ClientRectangle,
                0,
                0,
                renderWidth,
                renderHeight,
                GraphicsUnit.Pixel,
                imageAttributes);
        }

        e.Graphics.CompositingMode = CompositingMode.SourceOver;

        TextRenderer.DrawText(
            e.Graphics,
            Text,
            Font,
            ClientRectangle,
            Enabled ? ForeColor : SystemColors.GrayText,
            TextFormatFlags.HorizontalCenter |
            TextFormatFlags.VerticalCenter |
            TextFormatFlags.SingleLine);
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        _mouseOver = true;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        _mouseOver = false;
        _mouseDown = false;
        Invalidate();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        _mouseDown = true;
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        _mouseDown = false;
        Invalidate();
    }
}
