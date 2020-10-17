from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
def index():
    return render_template('threesixty.html')


@app.route('/uncomfortable')
def uncomfortable():
    return render_template('dreary.html')

@app.route('/wiertz')
def wiertz():
    return render_template('wiertz.html')

@app.route('/ensor')
def ensor():
    return render_template('ensor.html')

@app.route('/spilliaert')
def spilliaert():
    return render_template('spilliaert.html')


if __name__ == "__main__":
    app.run(debug=True)

