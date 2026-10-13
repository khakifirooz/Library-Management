namespace LibraryManagementWindowsForm;

internal static class UiLayout
{
    public static TableLayoutPanel Stack(params Control[] children)
    {
        var table = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1,
            RowCount = children.Length, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink,
            Margin = Padding.Empty, RightToLeft = RightToLeft.No };
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        for (var i = 0; i < children.Length; i++)
        {
            table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            children[i].Dock = DockStyle.Top;
            table.Controls.Add(children[i], 0, i);
        }
        return table;
    }

    public static Control Field(string title, Control input)
    {
        var label = new Label { Text = title, Dock = DockStyle.Fill, Height = 24,
            TextAlign = ContentAlignment.MiddleRight, RightToLeft = RightToLeft.Yes,
            ForeColor = UiTheme.Muted, AutoSize = false };
        input.Dock = DockStyle.Fill;
        input.Margin = new Padding(0, 2, 0, 2);
        var table = new TableLayoutPanel { ColumnCount = 1, RowCount = 2, Height = 68,
            Dock = DockStyle.Top, Margin = new Padding(0, 0, 0, 8), RightToLeft = RightToLeft.No };
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        table.RowStyles.Add(new RowStyle(SizeType.Absolute, 24));
        table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
        table.Controls.Add(label, 0, 0); table.Controls.Add(input, 0, 1);
        return table;
    }

    public static FlowLayoutPanel Actions(params Control[] buttons)
    {
        var panel = new FlowLayoutPanel { AutoSize = true, Dock = DockStyle.Top,
            FlowDirection = FlowDirection.RightToLeft, RightToLeft = RightToLeft.No,
            WrapContents = true, Padding = new Padding(0, 8, 0, 0) };
        panel.Controls.AddRange(buttons);
        return panel;
    }

    public static TableLayoutPanel Across(params Control[] children)
    {
        var table = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = children.Length,
            RowCount = 1, Margin = Padding.Empty, RightToLeft = RightToLeft.Yes };
        for (var i = 0; i < children.Length; i++)
        {
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / children.Length));
            children[i].Dock = DockStyle.Fill;
            children[i].Margin = new Padding(6);
            table.Controls.Add(children[i], i, 0);
        }
        table.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        return table;
    }

    public static TableLayoutPanel Split(Control list, Control editor, int editorWidth = 340)
    {
        var table = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 1,
            RightToLeft = RightToLeft.No, Margin = Padding.Empty };
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, editorWidth));
        table.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        list.Dock = DockStyle.Fill; editor.Dock = DockStyle.Fill;
        table.Controls.Add(list, 0, 0); table.Controls.Add(editor, 1, 0);
        return table;
    }

    public static TableLayoutPanel Card(string title, Control content)
    {
        var table = new TableLayoutPanel { Dock = DockStyle.Fill, BackColor = Color.White,
            ColumnCount = 1, RowCount = 2, Padding = new Padding(16), Margin = new Padding(6),
            RightToLeft = RightToLeft.No };
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        table.RowStyles.Add(new RowStyle(SizeType.Absolute, 34));
        table.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        var label = new Label { Text = title, Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleRight, RightToLeft = RightToLeft.Yes };
        content.Dock = DockStyle.Fill;
        table.Controls.Add(label, 0, 0); table.Controls.Add(content, 0, 1);
        return table;
    }

    public static Control ScrollFields(params Control[] fields)
    {
        var stack = Stack(fields);
        stack.Dock = DockStyle.Top;
        var scroll = new Panel { Dock = DockStyle.Fill, AutoScroll = true, RightToLeft = RightToLeft.No };
        scroll.Controls.Add(stack);
        return scroll;
    }

    public static Control GridArea(DataGridView grid, Label status, Control? toolbar = null)
    {
        var table = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 3,
            Margin = Padding.Empty, RightToLeft = RightToLeft.No };
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        table.RowStyles.Add(new RowStyle(SizeType.Absolute, toolbar is null ? 0 : 110));
        table.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        table.RowStyles.Add(new RowStyle(SizeType.Absolute, 32));
        if (toolbar is not null) { toolbar.Dock = DockStyle.Fill; table.Controls.Add(toolbar, 0, 0); }
        grid.Dock = DockStyle.Fill; table.Controls.Add(grid, 0, 1);
        status.Dock = DockStyle.Fill; table.Controls.Add(status, 0, 2);
        return table;
    }

    public static Control Photo(PictureBox picture, EventHandler choose)
    {
        picture.Dock = DockStyle.Fill;
        picture.SizeMode = PictureBoxSizeMode.Zoom;
        picture.Cursor = Cursors.Hand;
        var button = UiTheme.NewButton("انتخاب تصویر", choose);
        var table = new TableLayoutPanel { ColumnCount = 1, RowCount = 2, Height = 185,
            Dock = DockStyle.Top, Margin = new Padding(0, 6, 0, 12) };
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        table.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        table.RowStyles.Add(new RowStyle(SizeType.Absolute, 42));
        table.Controls.Add(picture, 0, 0); button.Dock = DockStyle.Fill; table.Controls.Add(button, 0, 1);
        return table;
    }

    public static void Install(Form form, string title, string subtitle, Control body,
        UserProfile? profile = null, int width = 1160, int height = 780, int minWidth = 960, int minHeight = 680)
    {
        // All reused controls are already parented to body/profile before old containers are disposed.
        var header = new TableLayoutPanel { ColumnCount = profile is null ? 1 : 2, RowCount = 1,
            Dock = DockStyle.Fill, BackColor = Color.White, Padding = new Padding(22, 10, 22, 8),
            RightToLeft = RightToLeft.Yes, Margin = Padding.Empty };
        header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        if (profile is not null) header.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240));
        var heading = new TableLayoutPanel { ColumnCount = 1, RowCount = 2, Dock = DockStyle.Fill };
        heading.RowStyles.Add(new RowStyle(SizeType.Percent, 58));
        heading.RowStyles.Add(new RowStyle(SizeType.Percent, 42));
        heading.Controls.Add(new Label { Text = title, Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleRight, RightToLeft = RightToLeft.Yes }, 0, 0);
        heading.Controls.Add(new Label { Text = subtitle, Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleRight, RightToLeft = RightToLeft.Yes, ForeColor = UiTheme.Muted }, 0, 1);
        header.Controls.Add(heading, 0, 0);
        if (profile is not null) { profile.Dock = DockStyle.Fill; header.Controls.Add(profile, 1, 0); }
        var root = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2,
            RightToLeft = RightToLeft.No, Margin = Padding.Empty };
        root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 86));
        root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        var canvas = new Panel { Dock = DockStyle.Fill, Padding = new Padding(18) };
        body.Dock = DockStyle.Fill; canvas.Controls.Add(body);
        root.Controls.Add(header, 0, 0); root.Controls.Add(canvas, 0, 1);
        form.SuspendLayout();
        var old = form.Controls.Cast<Control>().ToArray();
        form.Controls.Clear(); form.Controls.Add(root);
        foreach (var control in old) control.Dispose();
        UiTheme.Apply(form);
        // Accent is intentional for titles and helper text after the shared font is applied.
        heading.Controls[0].Font = new Font(form.Font.FontFamily, 16F, FontStyle.Bold);
        heading.Controls[1].ForeColor = UiTheme.Muted;
        form.Text = title;
        form.MinimumSize = new Size(minWidth, minHeight);
        var area = Screen.FromControl(form).WorkingArea;
        form.ClientSize = new Size(Math.Max(minWidth - 24, Math.Min(width, area.Width - 80)),
            Math.Max(minHeight - 56, Math.Min(height, area.Height - 100)));
        form.ResumeLayout(true);
    }
}
