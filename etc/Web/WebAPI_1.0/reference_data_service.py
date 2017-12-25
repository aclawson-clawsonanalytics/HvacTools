from bottle import Bottle, run, route, static_file, redirect
import os
import sys

REFERENCE_DATA_DIR = os.path.join(os.getcwd(), "ReferenceData")
VERSIONS_DIR = os.path.join(REFERENCE_DATA_DIR, "Versions")



app = Bottle()
@app.route('/hello')
def hello():
    return "Running Hvac Tools Web Service...."

@app.route('/info')
def info():    
    return 'Running HvacTools reference database web service. Database version: {}. Migration Number: {}'.format(1,1)

@app.route('/HvacReference/<version>/<migration_number>')
def getReferenceDatabaseByVersion(version, migration_number):
    dbFilename = "hvac_reference_" + str(version) + ".db"
    versionDirectory = os.path.join(VERSIONS_DIR, str(version))
    dbPath = os.path.join(versionDirectory, dbFilename)    
    if (os.path.exists(dbPath)):
        rootPath = os.path.join("/", versionDirectory)
        return static_file(dbFilename, root=rootPath, download=dbFilename)
    else:
        return "No file found at: " + dbPath 

@app.route('/HvacReference/current')
def getCurrentReferenceDatabase():
    redirect('/HvacReference/1')

run(app, host='', port=1234)