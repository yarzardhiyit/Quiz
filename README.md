# Quiz

```
        public frmQuiz()
        {
            InitializeComponent();
            Load += FrmQuiz_Load;
        }

        private void FrmQuiz_Load(object sender, EventArgs e)
        {
            SetActivePanel(ucHome1);
        }

        public void SetActivePanel(UserControl control)
        {
            ucHome1.Visible = false;
            ucQuiz11.Visible = false;
            ucQuiz21.Visible = false;
            ucQuiz31.Visible = false;

            control.Visible = true; 
        }
```

### App Preview

![Home](https://github.com/yarzardhiyit/yarzardhiyit/blob/main/qh1.png)
![Quiz1](https://github.com/yarzardhiyit/yarzardhiyit/blob/main/qh2.png)
![Quiz2](https://github.com/yarzardhiyit/yarzardhiyit/blob/main/qh3.png)
![Quiz3](https://github.com/yarzardhiyit/yarzardhiyit/blob/main/qh4.png)
![MessageBox](https://github.com/yarzardhiyit/yarzardhiyit/blob/main/qh5.png)

- Thanks.
