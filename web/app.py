from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
def index():
    return render_template('threesixty.html')


@app.route('/uncomfortable')
def uncomfortable():
    return render_template('dreary.html')

if __name__ == "__main__":
    app.run(debug=True)

