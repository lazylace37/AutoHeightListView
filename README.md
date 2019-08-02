# AutoHeightListView
 Xamarin.Forms implementation of an auto-height ListView
 
 I've made this little project because sometimes the default Xamarin.Forms' ListView doesn't calculate its height based on its children, and that can be the reason why you are here.

You can call it like that:
```
<views:AutoHeightListView HasUnevenRows="True" ItemsSource="{Binding Items}">
    <ListView.Header>
        ...
    </ListView.Header>

    <ListView.ItemTemplate>
        <DataTemplate>
            <ViewCell Height="25">
                <ViewCell.View>
                    <Grid>
                         ...
                    </Grid>
                </ViewCell.View>
            </ViewCell>
        </DataTemplate>
    </ListView.ItemTemplate>
</views:AutoHeightListView>
```

Now it is working only with HasUnevenRows set to True.
The Header height is dynamically retrieved, but I didn't manage to get the ViewCell's View height correctly, so for now I'm forcing the ViewCell's height.
You can also use the classic RowHeight property.

Any suggestions will be appreciated.
