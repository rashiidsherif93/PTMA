﻿using System;
using System.Runtime.InteropServices;

namespace ESI_USB_API_CS_Example
{
   public static class API
   {
      /// <summary>
      /// Searches all serial ports to find pressure sensors.  
      /// The number of sensors that were found is returned in the SensorCount parameter.
      /// </summary>
      /// <param name="sensorCount">The sensor count.</param>
      /// <returns>0 if sucessful, otherwise an error code.</returns>
      [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
      public static extern int FindSensors(ref int sensorCount);

        /// <summary>
        /// Retrieves information for a particular sensor
        /// </summary>
        /// <param name="sensorIndex">The zero-based index of the sensor.</param>
        /// <param name="portNumber">Reference to an int which will be used to return the port number.</param>
        /// <param name="serialNo">Reference to a byte array which will be used to return the serial no.</param>
        /// <param name="serialNumberLength">The maximum  number of characters that will be return forthe serial number.</param>
        /// <returns></returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetSensorInfo(int sensorIndex, ref int portNumber, [MarshalAs(UnmanagedType.LPArray), Out] byte[] serialNo, int serialNumberLength);

        /// <summary>
        /// Retrieves extended information for a particular sensor
        /// </summary>
        /// <param name="sensorIndex">The zero-based index of the sensor.</param>
        /// <param name="portNumber">Reference to an int which will be used to return the port number.</param>
        /// <param name="serialNo">Reference to a byte array which will be used to return the serial no.</param>
        /// <param name="serialNumberLength">The maximum  number of characters that will be return forthe serial number.</param>
        /// <param name="isFast">Reference to an int that will be used to return whether the sensor is fast (1) or slow (0).</param>
        /// <returns></returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetSensorInfoEx(int sensorIndex, ref int portNumber, [MarshalAs(UnmanagedType.LPArray), Out] byte[] serialNo, int serialNumberLength, ref int isFast);


        /// <summary>
        /// Opens communications with a sensor and sets it ready for use
        /// </summary>
        /// <param name="sensorIndex">The zero-based index of the sensor.</param>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int UseSensor(int sensorIndex);

        /// <summary>
        /// Opens communications with a sensor and sets it ready for use
        /// </summary>
        /// <param name="sensorIndex">The zero-based index of the sensor.</param>
        /// <param name="used">Reference to an int used to return whether the sensor is in use.</param>
        /// <returns>0 if sucessful, otherwise an error code. </returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int IsSensorUsed(int sensorIndex, ref int used);

        /// <summary>
        /// Closes communications with a sensor and releases it
        /// </summary>
        /// <param name="sensorIndex">The zero-based index of the sensor.</param>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReleaseSensor(int sensorIndex);

        /// <summary>
        /// Retrieves the manufacture date for a given sensor.
        /// </summary>
        /// <param name="sensorIndex">The zero-based index of the sensor.</param>
        /// <param name="ticks">Reference to an Int64 which will be used to return the date in ticks.</param>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetManufactureDate(int sensorIndex, ref Int64 ticks);

        /// <summary>
        /// Retrieves the calibration date for a given sensor.
        /// </summary>
        /// <param name="sensorIndex">The zero-based index of the sensor.</param>
        /// <param name="ticks">Reference to a Int64 which will be used to return the date in ticks.</param>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetCalibrationDate(int sensorIndex, ref Int64 ticks);


        /// <summary>
        /// Retrieves the API version 
        /// </summary>
        /// <param name="version">Reference to a byte array which will be used to return the API version.</param>
        /// <param name="versionLength">The maximum  number of characters that will be return for the API version.</param>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetAPIVersion([MarshalAs(UnmanagedType.LPArray), Out] byte[] version, int versionLength);

        /// <summary>
        /// Retrieves the pressure range for a given sensor.
        /// </summary>
        /// <param name="sensorIndex">The zero-based index of the sensor.</param>
        /// <param name="range">Reference to a float which will be used to return the range.</param>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetPressureRange(int sensorIndex, ref float range);

        /// <summary>
        /// This function is given a units code and returns a string containing the units in text form.
        /// </summary>
        /// <param name="units">The units.</param>
        /// <param name="unitString">A byte array that on return will contain the given units in text form.</param>
        /// <param name="unitStringLength">The size of the byte array</param>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetPressureUnits(int units, [MarshalAs(UnmanagedType.LPArray), Out] byte[] unitString, int unitStringLength);

        /// <summary>
        /// This function is given a temperature units code and returns a string containing the units in text form.
        /// </summary>
        /// <param name="units">The unit code.</param>
        /// <param name="unitString">A byte array that on return will contain the given units in text form.</param>
        /// <param name="unitStringLength">The size of the byte array</param>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetTemperatureUnits(int units, [MarshalAs(UnmanagedType.LPArray), Out] byte[] unitString, int unitStringLength);

        /// <summary>
        /// This function reads the pressure in the selected engineering units.
        /// </summary>
        /// <param name="sensorIndex">The zero-based index of the sensor.</param>
        /// <param name="units">The units.</param>
        /// <param name="absolute">A none-zero value indicates that the absolute pressure should be returned.</param>
        /// <param name="temperature">The temperature.</param>
        /// <param name="pressure">Reference to a float which will be used to return the pressure.</param>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Read(int sensorIndex, int units, int absolute, float temperature, ref float pressure);

        /// <summary>
        /// This function reads the temperature in the selected engineering units.
        /// </summary>
        /// <param name="sensorIndex">The zero-based index of the sensor.</param>
        /// <param name="units">The units.</param>
        /// <param name="temperature">Reference to a float which will be used to return the temperature.</param>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReadTemperature(int sensorIndex, int units, ref float temperature);


        /// <summary>
        /// This sets the difference between absolute and gauge pressures in bar.  
        /// The value is used in the Read function when giving absolute values.
        /// </summary>
        /// <param name="sensorIndex">The zero-based index of the sensor.</param>
        /// <param name="differential">The differential.</param>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetGaugeDifferential(int sensorIndex, float differential);

        /// <summary>
        /// Starts continuous reading of all active fast sensors.
        /// </summary>
        /// <param name="pressureInterval">The interval in seconds between each pressure reading.</param>
        /// <param name="temperatureInterval">The interval in seconds between each temperature reading.</param>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int StartMonitoring(double pressureInterval, double temperatureInterval);

        /// <summary>
        /// Stops the continuous reading of fast sensors previously started with a call to StartMonitoring..
        /// </summary>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int StopMonitoring();

        /// <summary>
        /// Gets the latest pressure and temperature readings for the specified sensor,
        /// </summary>
        /// <param name="sensorIndex">The zero-based index of the sensor.</param>
        /// <param name="time">The time of the reading.</param>
        /// <param name="pressure">An array containing all the pressure readings taken since the last call to GetMonitorData.</param>
        /// <param name="temperature">An array containing all the temperature readings taken since the last call to GetMonitorData.</param>
        /// <param name="length">The number of readings returned.</param>
        /// <param name="pressureUnits">The units that pressure readings should be returned in.</param>
        /// <param name="absolute">Indicates whether absolute (1) or gauge (0) pressure should be returned.</param>
        /// <param name="temperatureUnits">The units that temperature readings should be returned in.</param>
        /// <returns>
        /// 0 if sucessful, otherwise an error code.
        /// </returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetMonitorData(int sensorIndex,
          [MarshalAs(UnmanagedType.LPArray), Out] float[] time,
          [MarshalAs(UnmanagedType.LPArray), Out] float[] pressure,
          [MarshalAs(UnmanagedType.LPArray), Out] float[] temperature,
          ref int length, int pressureUnits, int absolute, int temperatureUnits);

        /// <summary>
        /// Gets the actual rate that readings area returned for the specified requested rate.
        /// </summary>
        /// <param name="requestedRate">The requested rate.</param>
        /// <param name="actualRate">The actual rate.</param>
        /// <returns>0 if sucessful, otherwise an error code./// </returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetActualRate(double requestedRate, ref double actualRate);

        /// <summary>
        /// This function must be called when the application code has finished using the library.  
        /// This closes communications and cleans up all system resources.
        /// </summary>
        /// <returns>0 if sucessful, otherwise an error code.</returns>
        [DllImport(@"Resources\ESI-USB-API.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int CleanUp();

   }
}
