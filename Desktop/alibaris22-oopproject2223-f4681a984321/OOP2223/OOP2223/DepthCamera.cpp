#include "DepthCamera.h"

DepthCamera::DepthCamera(string fileName) : fileName(fileName) {}

void DepthCamera::setFileName(string fileName)
{
    this->fileName = fileName;
}

string DepthCamera::getFileName()
{
    return fileName;
}

PointCloud DepthCamera::getPointCloud()
{
    return pointCloud;
}

void DepthCamera::setPointCloud(PointCloud pointCloud)
{
    this->pointCloud = pointCloud;
}

PointCloud DepthCamera::capture()
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
