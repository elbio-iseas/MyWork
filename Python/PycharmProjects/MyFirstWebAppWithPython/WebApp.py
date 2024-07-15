from flask import Flask

app = Flask(__name__)


@app.route('/')
def HiThere():
    return "<html><head><title>Web app in Python</title></head><body bgcolor = 'green' color='white'><br><br><h1><p align='center' style='color:white';>Hurrah!!!, my first web app in Python with Flask</p></h1></body></html>"


if __name__ == "__main__":
    app.run()
