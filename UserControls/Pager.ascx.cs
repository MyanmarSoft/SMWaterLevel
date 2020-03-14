using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace SMWaterLevel.UserControls
{
    public class PagerEventArgs : EventArgs
    {

        public int Number
        {
            get;
            set;
        }

        public bool First
        {
            get;
            set;
        }

        public bool Previous
        {
            get;
            set;
        }

        public bool Next
        {
            get;
            set;
        }

        public bool Last
        {
            get;
            set;
        }

        public int PageSize
        {
            get;
            set;
        }
    }
    public partial class Pager : UserControl
    {
        #region Events
        public event EventHandler<PagerEventArgs> Change;
        #endregion

        #region Properties

        public int TotalPages
        {
            get
            {
                if (ViewState["TotalPages"] == null)
                {
                    ViewState["TotalPages"] = 0;
                }

                return Convert.ToInt32(ViewState["TotalPages"]);
            }

            set
            {
                ViewState["TotalPages"] = value;
            }
        }

        public string FirstText
        {
            get;
            set;
        }

        public string PreviousText
        {
            get;
            set;
        }

        public string NextText
        {
            get;
            set;
        }

        public string LastText
        {
            get;
            set;
        }

        public string Separator
        {
            get;
            set;
        }

        public bool ShowGoTo
        {
            get;
            set;
        }

        public string CssClass
        {
            get;
            set;
        }

        public string ControlToBind
        {
            get;
            set;
        }

        public int NumberOfPages
        {
            get
            {
                if (ViewState["NumberOfPages"] == null)
                {
                    ViewState["NumberOfPages"] = 10;
                }

                return Convert.ToInt32(ViewState["NumberOfPages"]);
            }

            set
            {
                ViewState["NumberOfPages"] = value;
            }
        }

        public int CurrentPageNumber
        {
            get
            {
                if (ViewState["CurrentPageNumber"] == null)
                {
                    ViewState["CurrentPageNumber"] = 1;
                }

                return Convert.ToInt32(ViewState["CurrentPageNumber"]);
            }

            set
            {
                ViewState["CurrentPageNumber"] = value;
            }
        }

        public int PageSize
        {
            get
            {
                if (ViewState["PageSize"] == null)
                {
                    ViewState["PageSize"] = 10;
                }

                return Convert.ToInt32(ViewState["PageSize"]);
            }

            set
            {
                ViewState["PageSize"] = value;
            }
        }

        public object DataSource { get; set; }
        #endregion
        #region Public Methods
        public void Reset()
        {
            CurrentPageNumber = 1;
        }
        public override void DataBind()
        {
            Repeater rpt = (Repeater)this.Parent.FindControl(ControlToBind);
            if (rpt != null && DataSource != null)
            {
                DataTable dt = (DataTable)DataSource;
                if (dt != null && dt.Rows.Count > 0)
                {
                    TotalPages = dt.Rows.Count / PageSize;

                    if (dt.Rows.Count % PageSize > 0)
                    {
                        TotalPages++;
                    }
                    rpt.DataSource = GetData(dt, (CurrentPageNumber - 1) * PageSize, PageSize);
                    rpt.DataBind();
                    base.DataBind();
                    GenerateLinks();
                }
            }
        }

        public DataTable GetData(DataTable dt, int startIndex, int size)
        {
            if (size > dt.Rows.Count)
            {
                size = dt.Rows.Count;
            }

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            int endIndex = startIndex + size;

            if (endIndex > dt.Rows.Count - 1)
            {
                endIndex = dt.Rows.Count;
            }

            DataTable rtnTable = dt.Clone();
            rtnTable.Rows.Clear();
            for (int i = startIndex; i < endIndex; i++)
            {
                DataRow dr = rtnTable.NewRow();
                foreach (DataColumn col in dt.Columns)
                {
                    dr[col.ColumnName] = dt.Rows[i][col.ColumnName];
                }
                rtnTable.Rows.Add(dr);
            }
            return rtnTable;
        }

        public int GetMaximum()
        {
            int maximum = 10;
            int mod = CurrentPageNumber % (NumberOfPages);

            if (mod == 0) mod = NumberOfPages;
            maximum = CurrentPageNumber + (NumberOfPages - mod);

            if (maximum >= TotalPages) maximum = TotalPages;

            return maximum;
        }

        public int GetMinimum()
        {
            int minimum = 1;
            int maximum = 10;
            int mod = CurrentPageNumber % (NumberOfPages);

            if (mod == 0) mod = NumberOfPages;
            maximum = CurrentPageNumber + (NumberOfPages - mod);

            minimum = maximum - (NumberOfPages - 1);
            if (minimum <= 0) minimum = 1;
            if (maximum >= TotalPages) maximum = TotalPages;
            return minimum;
        }

        public void GenerateLinks()
        {
            var display = new List<int>();

            int min = GetMinimum();
            int max = GetMaximum();

            if (TotalPages > 1)
            {
                for (int i = min; i <= max; i++)
                {
                    display.Add(i);
                }

                // CalculateBoundry(NumberOfPages, TotalPages, CurrentPageNumber, out minimum, out maximum);

                RepeaterNumbers.DataSource = display;
                RepeaterNumbers.DataBind();


                if (TotalPages > max)
                {
                    if (TotalPages <= NumberOfPages)
                    {
                        DisplayNav(false);
                    }
                    else
                    {
                        DisplayNav(true);
                    }
                }

                //if (TotalPages < 1 || !ShowGoTo)
                //{
                //    ButtonGoTo.Visible = false;
                //    TextBoxGoTo.Visible = false;
                //}
                //else
                //{
                //    ButtonGoTo.Visible = true;
                //    TextBoxGoTo.Visible = true;
                //}

                if (CurrentPageNumber <= NumberOfPages)
                {
                    //LinkButtonFirst.Enabled = false;
                    LinkButtonPrevious.Enabled = false;
                }
                else
                {
                    //LinkButtonFirst.Enabled = true;
                    LinkButtonPrevious.Enabled = true;
                }

                if (TotalPages <= max)
                {
                    LinkButtonNext.Enabled = false;
                    //LinkButtonLast.Enabled = false;
                }
                else
                {
                    LinkButtonNext.Enabled = true;
                    //LinkButtonLast.Enabled = true;
                }
            }
        }

        #endregion

        #region Protected Methods

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ////LinkButtonFirst.Text = FirstText ?? "|<";
                //LinkButtonPrevious.Text = PreviousText ?? "<<";
                //LinkButtonNext.Text = NextText ?? ">>";
                ////LinkButtonLast.Text = LastText ?? ">|";

            }
        }
        protected bool IsCurrentPage(int pageNumber)
        {
            return pageNumber == CurrentPageNumber;
        }

        protected string GetCssForCurrent(int pageNumber)
        {
            if (IsCurrentPage(pageNumber))
            {
                return CssClass;
            }
            else
            {
                return "";
            }
        }
        protected void LinkButtonNumber_Click(object sender, EventArgs e)
        {
            if (Change != null)
            {
                var number = Convert.ToInt32(((LinkButton)sender).Text);
                CurrentPageNumber = number;
                var args = new PagerEventArgs
                {
                    First = false,
                    Previous = false,
                    Next = false,
                    Last = false,
                    Number = number,
                    PageSize = PageSize
                };
                Change(this, args);
            }
        }

        public void DisplayNav(bool show)
        {
            //LinkButtonFirst.Visible = show;
            LinkButtonPrevious.Visible = show;
            LinkButtonNext.Visible = show;
            //LinkButtonLast.Visible = show;
        }

        #endregion

        protected void LinkButtonPrevious_Click(object sender, EventArgs e)
        {
            if (Change != null)
            {
                int mod = CurrentPageNumber % NumberOfPages;
                if (mod == 0) mod = NumberOfPages;
                CurrentPageNumber = CurrentPageNumber - mod;


                if (CurrentPageNumber <= 0) CurrentPageNumber = 1;

                var args = new PagerEventArgs
                {
                    First = false,
                    Previous = true,
                    Next = false,
                    Last = false,
                    Number = CurrentPageNumber,
                    PageSize = PageSize
                };
                Change(this, args);
            }
        }

        protected void LinkButtonNext_Click(object sender, EventArgs e)
        {
            if (Change != null)
            {
                int mod = CurrentPageNumber % NumberOfPages;

                if (mod == 0)
                {
                    CurrentPageNumber = CurrentPageNumber + 1;
                }
                else
                {
                    mod = (NumberOfPages - mod) + 1;
                    CurrentPageNumber = CurrentPageNumber + mod;
                }

                var args = new PagerEventArgs
                {
                    First = false,
                    Previous = false,
                    Next = true,
                    Last = false,
                    Number = CurrentPageNumber,
                    PageSize = PageSize
                };
                Change(this, args);
            }
        }
    }
}
