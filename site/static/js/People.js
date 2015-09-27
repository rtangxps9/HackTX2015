var People = React.createClass({
    getInitialState: function() {
        return {
            people: ['frank', 'john', 'bob']
        }
    },
    render: function() {
        return (
           <h1>Hello there</h1> 
        )
    }
});

React.render(<People />, document.getElementById('table'));
