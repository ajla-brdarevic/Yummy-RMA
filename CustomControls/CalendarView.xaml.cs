using System.Collections.ObjectModel;
using System.Windows.Input;
using Yummy.Models;

namespace Yummy.CustomControls;

public partial class CalendarView : StackLayout
{
    #region BindableProperty
    public static readonly BindableProperty SelectedDateProperty = BindableProperty.Create(
    nameof(SelectedDate),
    typeof(DateTime),
    declaringType: typeof(CalendarView),
    defaultBindingMode: BindingMode.TwoWay,
    defaultValue: DateTime.Now
);

    public DateTime SelectedDate
    {
        get => (DateTime)GetValue(SelectedDateProperty);
        set => SetValue(SelectedDateProperty, value);
    }
    #endregion
    public ObservableCollection<Calendar> Dates { get; set; } = new ObservableCollection<Calendar>();
    public CalendarView()
    {
        InitializeComponent();
        BindDates(DateTime.Now);
        this.BindingContext = this;
    }

    private void BindDates(DateTime selectedDate)
    {
        int daysCount = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);
        for (int day = 1; day <= daysCount; day++)
        {
            Dates.Add(new Calendar
            {
                Date = new DateTime(selectedDate.Year, selectedDate.Month, day)
            });
        }
    }

    #region Commands
    public ICommand CurrentDateCommand => new Command<Calendar>((currentDate) =>
    {
        SelectedDate = currentDate.Date;
    });
    #endregion
}
