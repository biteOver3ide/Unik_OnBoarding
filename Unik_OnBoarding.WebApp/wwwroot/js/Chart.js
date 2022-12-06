new Chart(document.getElementById("myChart"), {
    type: 'pie',
    data: {
        labels: ["Done", "In progress", "None started", "Blocked", "Pending"],
        datasets: [{
            label: "Population (millions)",
            backgroundColor: ["#3e95cd", "#8e5ea2", "#3cba9f", "#e8c3b9", "#c45850"],
            data: [5, 8, 10, 1, 2]
        }]
    },
    options: {
        title: {
            display: true,
            text: 'Predicted world population (millions) in 2050'
        }
    }
});