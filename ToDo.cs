using System;


public class ToDo
{

    private string Title { get; set; }
    private string Description { get; set; }
    private dateOnly dueDate { get; set; }
    private bool Status { get; set; }
    public ToDo()
	{   
    }

    public ToDo(string Title, string Description, dateOnly dueDate. bool Status)
    {
        this.Title = Title;
        this.Description = Description;
        this.dueDate = dueDate;
        this.Status = Status;
    }
}
