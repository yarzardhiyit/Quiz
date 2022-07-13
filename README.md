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

![Home](https://github.com/yarzardhiyit/yarzardhiyit/blob/main/quizh1.png)
![Quiz1](https://github.com/yarzardhiyit/yarzardhiyit/blob/main/quizh2.png)
![Quiz2](https://github.com/yarzardhiyit/yarzardhiyit/blob/main/quizh3.png)
![Quiz3](https://github.com/yarzardhiyit/yarzardhiyit/blob/main/quizh4.png)

- Thanks.
