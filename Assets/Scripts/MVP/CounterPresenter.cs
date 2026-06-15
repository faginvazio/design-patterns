public class CounterPresenter
{
    private readonly ICounterView view;
    private readonly CounterModel model;


    public CounterPresenter(ICounterView view, CounterModel model)
    {
        this.view = view;
        this.model = model;

        view.UpdateCountText(model.Count);
    }

    public void OnIncButtonClicked()
    {
        model.Increment();
        view.UpdateCountText(model.Count);
    }

    public void OnResetButtonClicked()
    {
        model.Reset();
        view.UpdateCountText(model.Count);
    }
}
