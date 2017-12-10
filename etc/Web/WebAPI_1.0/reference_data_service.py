from bottle import Bottle, run, route, static_file, redirect
import os
import sys

REFERENCE_DATA_DIR = os.path.join(os.getcwd(), "ReferenceData")
VERSION_DIR = os.path.join(REFERENCE_DATA_DIR, "Versions")

app = Bottle()
@app.route('/hello')
def hello():
    return "Running Hvac Tools Web Service...."

@app.route('/HvacReference/<version>')
def getReferenceDatabaseByVersion(version):
    dbFilename = "hvac_reference_v" + str(version) + ".db"
    
    dbPath = os.path.join(VERSION_DIR, dbFilename)
    if (os.path.exists(dbPath)):
        rootPath = os.path.join("/", VERSION_DIR)
        return static_file(dbFilename, root=rootPath, download=dbFilename)
    else:
        return "No file found at: " + dbPath 

@app.route('/HvacReference/current')
def getCurrentReferenceDatabase():
    redirect('/HvacReference/1')

run(app, host='', port=1234)