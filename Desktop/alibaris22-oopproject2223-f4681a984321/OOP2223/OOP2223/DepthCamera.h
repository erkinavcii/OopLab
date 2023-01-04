#pragma once
#include <string>
#include <fstream>
#include <vector>

using namespace std;

class DepthCamera
{
private:
    string fileName;
    PointCloud pointCloud;

public:
    DepthCamera(string fileName) : fileName(fileName) {}

    void setFileName(string fileName) { this->fileName = fileName; }
    string getFileName() { return fileName; }

    PointCloud getPointCloud() { return pointCloud; }
    void setPointCloud(PointCloud pointCloud) { this->pointCloud = pointCloud; }

    PointCloud capture()
    {
        ifstream file(fileName);
        if (!file.is_open())
        {
            throw runtime_error("Unable to open file");
        }

        vector<Point> points;
        while (!file.eof())
        {
            float x, y, z;
            file >> x >> y >> z;
            Point p(x, y, z);
            points.push_back(p);
        }

        pointCloud.setPoints(points);
        return pointCloud;
    }
};
